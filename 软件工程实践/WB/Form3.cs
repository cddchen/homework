using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WB
{
    public partial class Form3 : Form
    {
        public Form3(MovieIfo movie)
        {
            InitializeComponent();
            
            if(movie.IconLink == "")
            {
                MessageBox.Show("NMSL");
                this.Close();
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            http = movie.IconLink;
            FinishGetPictureStream = false;
            Task.Run(() => GetPictureStream());
            Thread t = new Thread(CheckPictureStream);
            t.Start();
        }

        private void GetPictureStream()
        {
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(http);
            req.Method = "GET";
            //"application/x-www-form-urlencoded"
            req.ContentType = "ext/html,application/xhtml+xml,application/xml;" +
                "q=0.9,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3"; //由链接获取网页内容
            req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                "(KHTML, like Gecko) Chrome/76.0.3789.0 Safari/537.36 Edg/76.0.159.0";//识别用户浏览器环境
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            stream = res.GetResponseStream();
            FinishGetPictureStream = true;
        }

        private System.Timers.Timer t;
        private Stream stream = null;
        private bool FinishGetPictureStream = false;
        private string http = null;
        private void CheckPictureStream()
        {
            t = new System.Timers.Timer(100);
            t.AutoReset = true;
            t.Elapsed += T_Elapsed;
            t.Start();
        }

        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(FinishGetPictureStream)
            {
                t.Close();
                pictureBox1.Image = Image.FromStream(stream);
            }
        }
    }
}
