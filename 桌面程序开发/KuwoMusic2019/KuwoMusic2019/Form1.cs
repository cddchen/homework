using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuwoMusic2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lyrics = new Lyrics("陈一发儿-童话镇");
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private Lyrics lyrics;
        private int currentIndex = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics; int y = 0;
            for (int i = 0; i < lyrics.Line; ++i)
            {
                if (i == currentIndex) g.DrawString(lyrics.lyric_text[i], new Font("微软雅黑", 16), Brushes.Green , new PointF(400, 100 + 30 * y));
                else g.DrawString(lyrics.lyric_text[i], new Font("微软雅黑", 16), Brushes.Gray, new PointF(400, 100 + 30 * y));
                y++;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            this.Invalidate();
        }
    }
}
  