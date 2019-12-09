using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuwoMusic2019
{
    public class Lyrics
    {
        public List<string> lyric_text;
        public List<int> lyric_minute;
        public List<double> lyric_second;
        public Lyrics(string MusicName)
        {
            lyric_text = new List<string>();
            lyric_minute = new List<int>();
            lyric_second = new List<double>();
            this.LoadFromFile(MusicName);
        }
        public int Line
        {
            get { return lyric_text.Count;  }
        }
        void LoadFromFile(string MusicName)
        {
            try
            {
                FileStream fs = new FileStream("C:\\Users\\cdd13\\Desktop\\桌面程序开发\\KuwoMusic资源\\Lyric\\陈一发儿-童话镇.lrc", FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("GB2312"));
                string s = null;
                while ((s = sr.ReadLine()) != null)
                {
                    try
                    {
                        int minute = int.Parse(s.Substring(1, 2));
                        double second = double.Parse(s.Substring(4, 5));
                        string str = s.Substring(10);
                        lyric_minute.Add(minute);
                        lyric_second.Add(second);
                        lyric_text.Add(str);
                    }
                    catch (Exception ex) {
                    }
                }
                sr.Close();
            }
            catch (Exception ex) { }
        }
    }
}
