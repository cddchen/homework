using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace 开机记单词
{

    public partial class Word : UserControl
    {
        public Word()
        {
            InitializeComponent();
        }

        private int num = 2; // 正确答案位置区间[1, 2, 3]
        private bool isEnglish = false;
        private int flag = 0; // 判断当前处于什么界面 → [0 未解锁、1 选择答案、2 正确、3 错误]

        public void changeBackImg(Image image)
        {
            if(image == null)
            {
                this.BackgroundImage = null; // 清除背景图片
            }
            else
            {
                this.BackgroundImage = image;
            }
        }
        // 更改控件背景图片

        public void changeBackColor(int i)
        {
            if(i == 0)
            {
                this.BackColor = Color.Gold;  // 背景色——选择（黄色）
            }
            else if(i == 1)
            {
                this.BackColor = Color.Lime; // 背景色——正确
            }
            else if (i == 2)
            {
                this.BackColor = Color.Chartreuse;  // 背景色——正确（高光）
            }
            else if (i == 3)
            {
                this.BackColor = Color.Salmon; // 背景色——错误
            }
            else if (i == 4)
            {
                this.BackColor = Color.LightSalmon;  // 背景色——错误（高光）
            }
        }
        // 更改控件背景颜色

        public int returnFlag()  // 获取当前flag值，判断当前界面颜色
        {
            return this.flag;
        }


        #region 此控件背景
        private void Word_MouseEnter(object sender, EventArgs e)
        {
            if(flag == 0)
            {
                changeBackImg(Properties.Resources.上锁2);
            }
            else if(flag == 2)
            {
                changeBackColor(2);
            }
            else if(flag == 3)
            {
                changeBackColor(4);
            }
        }

        private void Word_MouseLeave(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                changeBackImg(Properties.Resources.上锁);
            }
            else if(flag == 2)
            {
                changeBackColor(1);
            }
            else if (flag == 3)
            {
                changeBackColor(3);
            }
        }

        private void Word_MouseClick(object sender, MouseEventArgs e)
        {
            if(flag == 0)
            {
                flag = 1;
                changeBackImg(null);
                changeBackColor(0);
                pictureBox1.Visible = true;
                //判断是否为英文题，才显示发音
                if (isEnglish) pronunciation.Visible = true;
                Question.Visible = true;
                mean1.Visible = true;
                mean2.Visible = true;
                mean3.Visible = true;
            }
        }

        #endregion

        #region 汉语意思
        private void mean1_MouseEnter(object sender, EventArgs e)
        {
            if(flag == 1)
            {
                mean1.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
            else if(flag == 2)
            {
                changeBackColor(2);
            }
            else if(flag == 3)
            {
                mean1.BackColor = Color.FromArgb(100, 255, 255, 255);
                changeBackColor(4);
            }
        }

        private void mean2_MouseEnter(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                mean2.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
            else if (flag == 2)
            {
                changeBackColor(2);
            }
            else if (flag == 3)
            {
                mean2.BackColor = Color.FromArgb(100, 255, 255, 255);
                changeBackColor(4);
            }
        }

        private void mean3_MouseEnter(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                mean3.BackColor = Color.FromArgb(100, 255, 255, 255);
            }
            else if (flag == 2)
            {
                changeBackColor(2);
            }
            else if (flag == 3)
            {
                mean3.BackColor = Color.FromArgb(100, 255, 255, 255);
                changeBackColor(4);
            }
        }

        private void mean1_MouseLeave(object sender, EventArgs e)
        {
            mean1.BackColor = Color.Transparent;
        }

        private void mean2_MouseLeave(object sender, EventArgs e)
        {
            mean2.BackColor = Color.Transparent;
        }

        private void mean3_MouseLeave(object sender, EventArgs e)
        {
            mean3.BackColor = Color.Transparent;
        }

        
        private void mean1_MouseClick(object sender, MouseEventArgs e)
        {
            if(flag != 2)
            {
                if (num == 1)
                {
                    flag = 2;
                    changeBackColor(2);
                    pictureBox1.Image = Properties.Resources.正确;
                }
                else
                {
                    flag = 3;
                    changeBackColor(4);
                    pictureBox1.Image = Properties.Resources.错误;
                }
            }
        }

        private void mean2_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag != 2)
            {
                if (num == 2)
                {
                    flag = 2;
                    changeBackColor(2);
                    pictureBox1.Image = Properties.Resources.正确;
                }
                else
                {
                    flag = 3;
                    changeBackColor(4);
                    pictureBox1.Image = Properties.Resources.错误;
                }
            }
        }

        private void mean3_MouseClick(object sender, MouseEventArgs e)
        {
            if (flag != 2)
            {
                if (num == 3)
                {
                    flag = 2;
                    changeBackColor(2);
                    pictureBox1.Image = Properties.Resources.正确;
                }
                else
                {
                    flag = 3;
                    changeBackColor(4);
                    pictureBox1.Image = Properties.Resources.错误;
                }
            }
        }

        #endregion

        #region 音频播放
        private void pronunciation_MouseEnter(object sender, EventArgs e)
        {
            pronunciation.BackColor = Color.FromArgb(100, 255, 255, 255);
            if (flag == 2)
            {
                changeBackColor(2);
            }
            else if (flag == 3)
            {
                changeBackColor(4);
            }
        }

        private void pronunciation_MouseLeave(object sender, EventArgs e)
        {
            pronunciation.BackColor = Color.Transparent;
        }

        private void pronunciation_MouseClick(object sender, MouseEventArgs e)
        {
            MediaPlay1.URL = "http://dict.youdao.com/speech?audio=" + Question.Text;
            MediaPlay1.Ctlcontrols.play();
        }

        #endregion

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (flag == 2)
            {
                changeBackColor(2);
            }
            else if (flag == 3)
            {
                changeBackColor(4);
            }
        }

        private void Word_Load(object sender, EventArgs e)
        {
            Problem problem = new Problem();
            problem.Get();
            num = problem.CorrectId;
            Question.Text = problem.Question;
            mean1.Text = problem.Ans1;
            mean2.Text = problem.Ans2;
            mean3.Text = problem.Ans3;
            isEnglish = problem.IsEnglish;
            if (!problem.IsEnglish)
                Question.Font = new Font("微软雅黑", 13, FontStyle.Bold);
        }
    }
}
