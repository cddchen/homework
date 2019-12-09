using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 腾讯QQ
{
    public partial class Form2Weather : Form
    {
        public int currentCount = 0;
        public int flag = 0;
        string getInfo = null;
        public Form2Weather()
        {
            InitializeComponent();
            if (getInfo == null)
            {
                Task task = new Task(() => GetHttpResponse("http://v.juhe.cn/weather/index?format=2&dtype=xml&cityname=成都&key=efc6c4da1fe8094d19be7c59e5706c70", 1000));
                task.Start();
            }
            timerCheckIfo.Start();
            //SetGifBackground();
        }

        private void calcWea()
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(getInfo);
            XmlElement xmlRoot = doc.DocumentElement;
            XmlNode node = xmlRoot.ChildNodes[2];
            XmlNode today = node.ChildNodes[1];
            TodayDegree.Text = today.ChildNodes[0].InnerText;
            weather.Text = today.ChildNodes[1].InnerText;
            airCondition.Text = today.ChildNodes[3].InnerText;
            XmlNode future = node.ChildNodes[2];
            XmlNode item = future.ChildNodes[0];
            todayWea.Text = item.ChildNodes[0].InnerText;
            if ((item.ChildNodes[0].InnerText) == "小雨")
                pictureBox5.Image = Properties.Resources.下雨;
            else if ((item.ChildNodes[0].InnerText) == "多云")
                pictureBox5.Image = Properties.Resources.多云;
            else if ((item.ChildNodes[0].InnerText) == "晴转多云")
                pictureBox5.Image = Properties.Resources.多云;

            item = future.ChildNodes[1];
            tomWea.Text = item.ChildNodes[0].InnerText;
            if ((item.ChildNodes[0].InnerText) == "小雨")
                pictureBox3.Image = Properties.Resources.下雨;
            else if ((item.ChildNodes[0].InnerText) == "多云")
                pictureBox3.Image = Properties.Resources.多云;
            else if ((item.ChildNodes[0].InnerText) == "晴转多云")
                pictureBox3.Image = Properties.Resources.多云;

            item = future.ChildNodes[2];
            afterdayWea.Text = item.ChildNodes[0].InnerText;
            if ((item.ChildNodes[0].InnerText) == "小雨")
                pictureBox2.Image = Properties.Resources.下雨;
            else if ((item.ChildNodes[0].InnerText) == "多云")
                pictureBox2.Image = Properties.Resources.多云;
            else if ((item.ChildNodes[0].InnerText) == "晴转多云")
                pictureBox2.Image = Properties.Resources.太阳;
            SetGifBackground();
        }

        public void setLocation(Point p, int w)
        {
            this.Location = new Point(p.X + w, p.Y);
        }
        public void GetHttpResponse(string url, int Timeout)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                request.UserAgent = null;
                request.Timeout = Timeout;

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                getInfo = retString;
            }
            catch(Exception ex)
            {
                GetHttpResponse(url, Timeout);
            }
        }
        private void SetGifBackground()
        {
            Image gif = Properties.Resources.乌云闪电;
            if (weather.Text == "小雨")
                gif = Properties.Resources.乌云闪电;
            else if (weather.Text == "多云")
                gif = Properties.Resources.云;
            else if (weather.Text == "晴转多云")
                gif = Properties.Resources.阳光;
            System.Drawing.Imaging.FrameDimension fd = new System.Drawing.Imaging.FrameDimension(gif.FrameDimensionsList[0]);
            int count = gif.GetFrameCount(fd);    //获取帧数(gif图片可能包含多帧，其它格式图片一般仅一帧)
            Timer timer1 = new Timer();
            timer1.Interval = 100;
            int i = 0;
            Image bgImg = null;
            timer1.Tick += (s, e) =>
            {
                if (i >= count) { i = 0; }
                gif.SelectActiveFrame(fd, i);
                System.IO.Stream stream = new System.IO.MemoryStream();
                gif.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                if (bgImg != null) { bgImg.Dispose(); }
                bgImg = Image.FromStream(stream);
                this.BackgroundImage = bgImg;
                i++;
            };
            timer1.Start();
            WeaBackTrans.BackColor = Color.FromArgb(0, 0, 0, 100);
        } // 窗体加载动图的方法

        #region MouseEnter、MouseLeave
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.FromArgb(60, 255, 255, 255);
        }


        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Transparent;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }


        #endregion

        private void Form2Weather_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start(); // 鼠标移开便开始计时
            flag = 0;
        }

        private void Form2Weather_Load(object sender, EventArgs e)
        {
            //设置Timer控件可用
            timer1.Enabled = false;
            //设置时间间隔（毫秒为单位）
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int X = MousePosition.X;
            int Y = MousePosition.Y;
            int num = 0;
            if (this.Location.X <= X && X <= this.Location.X + this.Width && this.Location.Y <= Y && Y <= this.Location.Y + this.Height)
                num = 1;
            currentCount += 1;
            if (currentCount == 1 && num == 0&&flag == 0) // 1秒后关闭“天气”界面
            {
                timer1.Stop();
                this.Visible = false;
            }
            currentCount = 0;
        }

        private void Form2Weather_MouseEnter(object sender, EventArgs e)
        {
            flag = 1;
        }

        private void timerCheckIfo_Tick(object sender, EventArgs e)
        {
            if (getInfo != null)
            {
                calcWea();
                timerCheckIfo.Stop();
            }
        }
    }
}
