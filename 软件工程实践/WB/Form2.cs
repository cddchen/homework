using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WB
{
    public partial class Form2 : Form
    {
        public static List<MovieIfo> movies;
        public Form2()
        {
            InitializeComponent();

            panel1.Location = new Point(12, 100);
            panel1.Show();
            panel2.Hide();

            movies = new List<MovieIfo>();//初始化存电影的链表
        }
        private bool IsFinishGetMovie = false;
        private void Button1_Click(object sender, EventArgs e)
        {
            //初始化
            //多线程
            IsFinishGetMovie = false; 
            Task.Run(() => DygangMovie());
            Thread t = new Thread(CheckGetMovieStatus);
            t.Start();
            //新建从电影港网站搜索的类
            panel1.Location = new Point(12, 12);//将panel1移动到顶部
            panel2.Show();
            button3.Text = "1/3";
            
        }

        private void DygangMovie()
        {
            Movie movie = new Dygang_movie();
            movie.movieName = comboBox1.Text;
            movie.PostWebContent();
            movies = movie.movies;
            IsFinishGetMovie = true;
        }

        private System.Timers.Timer t;
        private void CheckGetMovieStatus()
        {
            t = new System.Timers.Timer(100);
            t.AutoReset = true;
            t.Elapsed += T_Elapsed;
            t.Start();
        }

        private void T_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if(IsFinishGetMovie)
            {
                t.Close();
                button3.Text = "2/3";
                output_Key_Movies(movies);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //推出界面信息
            DialogResult result = MessageBox.Show("不再看看了吗？", "提示", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private int i = 0;
        public void output_Key_Movie(MovieIfo ifo, int id)
        {
            if (this.panel2.InvokeRequired)
            {
                panel2.BeginInvoke(new Action(() =>
                {
                    GroupBox groupBox = new GroupBox();
                    {
                        groupBox.Location = new Point(5, 50 + 160 * i++);
                        groupBox.Size = new Size(750, 150);
                        groupBox.Text = "电影名称：" + ifo.Name;
                        groupBox.Tag = id;
                        groupBox.Click += new EventHandler(groupBox_Click);
                    }
                    panel2.Controls.Add(groupBox);
                    //groupBoxes.Add(groupBox);

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Location = new Point(10, 20);
                    pictureBox.Size = new Size(100, 150);
                    ///////////////显示图片

                    //Label
                    string[] str1 = { "导演：", "主演：", "标签：", "日期：", "片长：" };
                    string[] str2 = { ifo.Director, ifo.Actors, ifo.Tag, ifo.Date, ifo.Time };
                    for (int j = 0; j < 5; j++)
                    {
                        Label label = new Label();
                        {
                            label.Location = new Point(120, 25 + 20 * j);//设置位置
                            label.Size = new Size(200, 15);//设置大小
                            label.Text = str1[j] + str2[j];
                        }
                        groupBox.Controls.Add(label);//在当前窗体上添加这个label控件
                    }
                    /*
                    Label label1 = new Label();
                    {
                        label1.Location = new Point(300, 25);
                        label1.Size = new Size(300, 120);
                        label1.AutoSize = false;
                        label1.Text = "内容简介：" + ifo.Introduction;
                    }
                    groupBox.Controls.Add(label1);//在当前窗体上添加这个label控件
                    */
                }));
            }
            else
            {
                GroupBox groupBox = new GroupBox();
                {
                    groupBox.Location = new Point(5, 50 + 160 * i++);
                    groupBox.Size = new Size(750, 150);
                    groupBox.Text = "电影名称：" + ifo.Name;
                    groupBox.Tag = id;
                    groupBox.Click += new EventHandler(groupBox_Click);
                }
                panel2.Controls.Add(groupBox);
                //groupBoxes.Add(groupBox);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(10, 20);
                pictureBox.Size = new Size(100, 150);
                ///////////////显示图片

                //Label
                string[] str1 = { "导演：", "主演：", "标签：", "日期：", "片长：" };
                string[] str2 = { ifo.Director, ifo.Actors, ifo.Tag, ifo.Date, ifo.Time };
                for (int j = 0; j < 5; j++)
                {
                    Label label = new Label();
                    {
                        label.Location = new Point(120, 25 + 20 * j);//设置位置
                        label.Size = new Size(200, 15);//设置大小
                        label.Text = str1[j] + str2[j];
                    }
                    groupBox.Controls.Add(label);//在当前窗体上添加这个label控件
                }
                /*Label label1 = new Label();
                {
                    label1.Location = new Point(300, 25);
                    label1.Size = new Size(300, 120);
                    label1.AutoSize = false;
                    label1.Text = "内容简介：" + ifo.Introduction;
                }
                groupBox.Controls.Add(label1);//在当前窗体上添加这个label控件
                */
            }
        }
        
        public void output_Key_Movies(List<MovieIfo> L_Movies)
        {
            for (int i = 0; i < L_Movies.Count; i++)
            {
                Task.Run(() => output_Key_Movie(L_Movies[i], i));
                /*
                MovieIfo ifo = L_Movies[i];
                GroupBox groupBox = new GroupBox();
                {
                    //groupBox.Location = new Point(5, 50 + 160 * i++);
                    groupBox.Size = new Size(750, 150);
                    groupBox.Text = "电影名称：" + ifo.Name;
                    groupBox.Tag = i;
                    groupBox.Click += new EventHandler(groupBox_Click);
                }
                //panel2.Controls.Add(groupBox);
                groupBoxes.Add(groupBox);

                PictureBox pictureBox = new PictureBox();
                pictureBox.Location = new Point(10, 20);
                pictureBox.Size = new Size(100, 150);
                ///////////////显示图片

                //Label
                string[] str1 = { "导演：", "主演：", "标签：", "日期：", "片长：" };
                string[] str2 = { ifo.Director, ifo.Actors, ifo.Tag, ifo.Date, ifo.Time };
                for (int j = 0; j < 5; j++)
                {
                    Label label = new Label();
                    {
                        label.Location = new Point(120, 25 + 20 * j);//设置位置
                        label.Size = new Size(200, 15);//设置大小
                        label.Text = str1[j] + str2[j];
                    }
                    groupBox.Controls.Add(label);//在当前窗体上添加这个label控件
                }
                Label label1 = new Label();
                {
                    label1.Location = new Point(300, 25);
                    label1.Size = new Size(300, 120);
                    label1.AutoSize = false;
                    label1.Text = "内容简介：" + ifo.Introduction;
                }
                groupBox.Controls.Add(label1);//在当前窗体上添加这个label控件
                */
                button2.Text = (int.Parse(button2.Text) + 1).ToString();
            }
            
            button3.Text = "3/3";
        }

        private void groupBox_Click(object o, EventArgs e)
        {
            GroupBox groupBox = (GroupBox)o;
            Form3 form3 = new Form3(movies[Convert.ToInt32(groupBox.Tag)]);//groupBox.Tag就是i，就是此时的第i个电影
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }

    //链接结构体
    public struct Link
    {
        public string type;//保存下载链接属于迅雷、磁力等类型
        public string linkname;//链接的名称如复仇者联盟3-1080p
        public string link;//具体下载链接
    }

    //电影结构体
    public struct MovieIfo
    {
        public string Name;//名称
        public string Director;//导演
        public string Actors;//主演
        public string Tag;//标签
        public string Language;//语言
        public string Subtitle;//字幕
        public string Date;//日期
        public string Time;//片长
        public string Introduction;//简介
        public string Source;//来源
        public string OnlinePlayLink;//在线播放链接
        public List<Link> Links;//下载链接链表
        public string IconLink;//封面
        public string NowLink;//抓取链接的所属网页
    }
}
