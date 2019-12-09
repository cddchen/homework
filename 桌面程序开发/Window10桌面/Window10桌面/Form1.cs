using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window10桌面
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;//设置本窗体
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true); // 禁止擦除背景.
            SetStyle(ControlStyles.DoubleBuffer, true); // 双缓冲
        }

        public string Week()
        {
            string[] weekdays = { "星期日", "星期一", "星期二", "星期三", "星期四", "星期五", "星期六" };
            string week = weekdays[Convert.ToInt32(DateTime.Now.DayOfWeek)];

            return week;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TimeLbl.Text = DateTime.Now.GetDateTimeFormats('t')[0].ToString();
            DateLbl.Text = DateTime.Now.GetDateTimeFormats('M')[0].ToString()+",";
            Lbl.Text = Week();
            PassPanel.Hide();
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            Image img = Properties.Resources.矩形_3;//双引号里是图片的路径
            PassPic.Image = img;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            Image img = Properties.Resources.矩形2;//双引号里是图片的路径
            PassPic.Image = img;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Image img = Properties.Resources._2;//双引号里是图片的路径
            this.BackgroundImage = img;
            IconPic.Visible = true;
            PassTxtBox.Visible = true;
            PassPic.Visible = true;
            PassTxtBox.Text = "";
            NickNameLbl.Visible = true;
            TimeLbl.Visible = false;
            DateLbl.Visible = false;
            Lbl.Visible = false;
            PassPanel.Show();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            PassTxtBox.Text = "";
            PassTxtBox.UseSystemPasswordChar = true;
            PassTxtBox.ForeColor = Color.Black;
            PassTxtBox.BackColor = Color.White;
            Image img = Properties.Resources.矩形_3;//双引号里是图片的路径
            PassPic.Image = img;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            string password = "346755";
            if(PassTxtBox.Text == password)
            {
                FormDesk dsk = new FormDesk();
                dsk.Show();
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                string password = "346755";
                if (PassTxtBox.Text == password)
                {
                    FormDesk dsk = new FormDesk();
                    dsk.Show();
                }
                else
                {
                    PassPanel.Hide();
                    TipPanel.Show();
                }
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Gainsboro;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Transparent;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Gainsboro;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.BackColor = Color.Transparent;
        }

        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Gainsboro;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.BackColor = Color.Transparent;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if(pictureBox6.Visible == false )
            {
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                PassTxtBox.BackColor = Color.DimGray;
            }
            else
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
            }
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            Image img = Properties.Resources.重启2;//双引号里是图片的路径
            pictureBox6.Image = img;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            Image img = Properties.Resources.重启;//双引号里是图片的路径
            pictureBox6.Image = img;
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            Image img = Properties.Resources.关机2;//双引号里是图片的路径
            pictureBox7.Image = img;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            Image img = Properties.Resources.关机3;//双引号里是图片的路径
            pictureBox7.Image = img;
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            Image img = Properties.Resources.睡眠4;//双引号里是图片的路径
            pictureBox8.Image = img;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            Image img = Properties.Resources.睡眠1;//双引号里是图片的路径
            pictureBox8.Image = img;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfrimBt_Click(object sender, EventArgs e)
        {
            TipPanel.Hide();
            PassTxtBox.Text = "";
            PassPanel.Show();
        }

        private void PassPic_Click(object sender, EventArgs e)
        {
            string password = "346755";
            if (PassTxtBox.Text == password)
            {
                FormDesk dsk = new FormDesk();
                dsk.Show();
            }
            else
            {
                PassPanel.Hide();
                TipPanel.Show();
            }
        }
    }
}
