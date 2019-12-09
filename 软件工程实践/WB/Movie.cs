using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;

namespace WB
{
    public class Movie
    {
        public string movieName;

        public List<MovieIfo> movies = new List<MovieIfo>();//电影信息结构体链表，记得初始化
        public virtual void PostWebContent() { } //电影搜索函数  
    }
    public class Dygang_movie : Movie
    {
        public override void PostWebContent()//搜索电影
        {
            //用GB2312编码方式访问程序代码（有中文网站不能识别，需要把中文编码）
            byte[] data = Encoding.GetEncoding("GB2312").GetBytes("++" +
                "tempid=1&tbname=article&keyboard=" + movieName + "&show=title&Submit=搜索");
            //访问电影港网址，以POST提交数据，并接受返回的页面内容
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://sou.dygang.net/e/search/index.php");
            req.Method = "POST";
            //req.AllowAutoRedirect = true;
            req.ContentType = "application/x-www-form-urlencoded";//用这种编码方式将返回的页面内容转换成一个个字符串
            req.ContentLength = data.Length;
            Stream s = req.GetRequestStream();
            s.Write(data, 0, data.Length);//写入文件操作
            s.Close();
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();//返回GetResponse对象
            //把响应的数据流绑定到StreamReader对象
            StreamReader reader = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding("GB2312"));
            string output = reader.ReadToEnd();
            MatchToMovie(output);//调用匹配电影函数
        }
        public void MatchToMovie(string WebContent)//匹配电影函数，参数为搜索到的页面内容
        {
            Regex regex = new Regex("<td width=\"250\"><a href=\"(.*)\" target=\"_blank\" class=\"classlinkclass\">(.*)</a></td>");
            MatchCollection Matches = regex.Matches(WebContent);//将正则表达式应用于找到匹配的集合，在WebContent中搜索匹配项
            foreach (Match m in Matches)
            {
                string webcontent = GetWebContent(m.Groups[1].ToString());//匹配到一个电影链接，调用匹配电影信息函数，eg：匹配到复仇者联盟3和电影链接
                if (webcontent != null)
                    MatchToIfo(webcontent);
            }
        }
        public string GetWebContent(string url)//获取搜索到的电影内的具体网页内容，参数为电影链接，eg：复仇者联盟3的具体链接
        {
            //用GET方式提交搜索到的链接
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "GET";
            //"application/x-www-form-urlencoded"
            req.ContentType = "ext/html,application/xhtml+xml,application/xml;" +
                "q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3"; //由链接获取网页内容
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                "(KHTML, like Gecko) Chrome/76.0.3789.0 Safari/537.36 Edg/76.0.159.0";//识别用户浏览器环境
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();//发出请求并获取对象
            //以GB312编码方式获取对象的流存入reader并用StreamReader进行读取
            StreamReader reader = new StreamReader(res.GetResponseStream(), Encoding.GetEncoding("GB2312"));
            string output = reader.ReadToEnd();//将读取的字符存储
            return output;
        }
        public void MatchToIfo(string Webcontent)//匹配电影信息函数，参数为获取到的具体电影网页内容
        {
            //正则表达式-匹配a标签以及a标签的hert属性
            Regex regexTitle = new Regex("【<a href=\"(.*)\">(.*)</a>】");
            Match match = regexTitle.Match(Webcontent);
            MovieIfo ifo;//电影信息结构体
            ifo.IconLink = ifo.Introduction = ifo.NowLink = ifo.Name = ifo.OnlinePlayLink = 
                ifo.Actors = ifo.Director = ifo.Tag = ifo.Language = ifo.Date = ifo.Time = 
                ifo.Introduction = ifo.Source = ifo.Subtitle =  null;//初始化
            ifo.Links = new List<Link>();//初始化
            //if表达式匹配成功将其信息赋值给结构体
            if (match.Success)
            {
                ifo.NowLink = match.Groups[1].ToString();
                ifo.Name = match.Groups[2].ToString();
            }
            else return;
            Regex regexIcon = new Regex("<p><img alt=\"\" src=\"(.*)\" />");
            match = regexIcon.Match(Webcontent);
            if(match.Success)
            {
                ifo.IconLink = match.Groups[1].ToString();
            }
            //匹配简介
            Regex regexYear = new Regex("◎年　　代(.*)<br />");
            match = regexYear.Match(Webcontent);
            if (match.Success)
            {
                ifo.Time = match.Groups[1].ToString();
            }
            Regex regexLang = new Regex("◎字　　幕(.*)<br />");
            match = regexLang.Match(Webcontent);
            if (match.Success)
            {
                ifo.Subtitle = match.Groups[1].ToString();
            }
            else
            {
                regexLang = new Regex("语言:(.*)<br />");
                match = regexLang.Match(Webcontent);
                if (match.Success) ifo.Subtitle = match.Groups[1].ToString();
                else
                {
                    regexLang = new Regex("◎语　　言(.*)<br />");
                    match = regexLang.Match(Webcontent);
                    if (match.Success) ifo.Subtitle = match.Groups[1].ToString();
                }
            }
            Regex regexTime = new Regex("◎上映日期(.*)<br />");
            match = regexTime.Match(Webcontent);
            if (match.Success)
            {
                ifo.Date = match.Groups[1].ToString();
            }
            else
            {
                regexTime = new Regex("上映日期:(.*)<br />");
                match = regexTime.Match(Webcontent);
                if(match.Success) ifo.Date = match.Groups[1].ToString();
                else
                {
                    regexTime = new Regex("[时 间]:(.*)");
                    match = regexTime.Match(Webcontent);
                    if (match.Success) ifo.Date = match.Groups[1].ToString();
                }
            }
            Regex regexDirector = new Regex("导　　演(.*)<br />");
            match = regexDirector.Match(Webcontent);
            if (match.Success)
            {
                ifo.Director = match.Groups[1].ToString();
            }
            else
            {
                regexDirector = new Regex("[导 演]:(.*)");
                match = regexDirector.Match(Webcontent);
                if(match.Success) ifo.Director = match.Groups[1].ToString();
                else
                {
                    regexDirector = new Regex("导演:(.*)<br />");
                    match = regexDirector.Match(Webcontent);
                    if (match.Success) ifo.Director = match.Groups[1].ToString();
                }
            }
            Regex regexActor = new Regex("◎主　　演(.*)<br />");
            match = regexActor.Match(Webcontent);
            if (match.Success)
            {
                ifo.Actors = match.Groups[1].ToString();
            }
            else
            {
                regexActor = new Regex("主演:(.*)<br />");
                match = regexActor.Match(Webcontent);
                if(match.Success) ifo.Actors = match.Groups[1].ToString();
                else
                {
                    regexActor = new Regex("[演 员]:(.*)");
                    match = regexActor.Match(Webcontent);
                    if (match.Success) ifo.Actors = match.Groups[1].ToString();
                }
            }
            Regex regexRank = new Regex("◎豆瓣评分(.*)");
            match = regexRank.Match(Webcontent);
            if (match.Success)
            {
                ifo.Language = match.Groups[1].ToString();
            }
            Regex regexOnlineLink = new Regex("在线观看：<a target=\"_blank\" href=\"(.*)\">");//匹配在线播放链接
            match = regexOnlineLink.Match(Webcontent);
            if (match.Success)
            {
                ifo.OnlinePlayLink = match.Groups[1].ToString();
            }
            Regex regexLinks = new Regex("<td bgcolor=\"#ffffbb\" width=\"100%\" style=\"word-break: break-all; line-height: 18px\">(.*)：<a href=\"(.*)\">(.*)</a>");
            MatchCollection matchlinks = regexLinks.Matches(Webcontent);//将网页内容matchlinks中在循环中进行赋值
            foreach (Match link in matchlinks)
            {
                Link item;
                item.type = link.Groups[1].ToString();
                item.linkname = link.Groups[2].ToString();
                item.link = link.Groups[3].ToString();
                ifo.Links.Add(item);
            }
            if(matchlinks.Count == 0)
            {
                regexLinks = new Regex("<td bgcolor=\"#ffffbb\" width=\"100%\" style=\"word-break: break-all; line-height: 18px\"><a href=\"(.*)\">(.*)</a></td>");
                matchlinks = regexLinks.Matches(Webcontent);
                foreach (Match link in matchlinks)
                {
                    Link item;
                    item.type = "电视剧";
                    item.linkname = link.Groups[1].ToString();
                    item.link = link.Groups[2].ToString();
                    ifo.Links.Add(item);
                }
            }
            movies.Add(ifo);
        }
    }
}
