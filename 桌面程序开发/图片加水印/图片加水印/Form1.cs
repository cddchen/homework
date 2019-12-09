using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 图片加水印
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region MouseUp、Down
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.原图1;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Properties.Resources.原图0;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.水图1;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Properties.Resources.水图0;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Properties.Resources.保存图片1;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Properties.Resources.保存图片0;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Properties.Resources.批量1;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Properties.Resources.批量0;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Properties.Resources.按钮1;

            timer1.Enabled = true;
            timer1.Start(); 
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Properties.Resources.按钮0;

            timer1.Stop();
        }

        //实现水印可任意拖动
        private Point mouse_offset;
        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }
        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos = PointToClient(mousePos);
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                mousePos = new Point(mousePos.X - pictureBox8.Width / 2, mousePos.Y - pictureBox8.Height / 2);
                pictureBox8.Location = mousePos;
                pictureBox8.Invalidate();
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Interval = 10;
            comboBox1.Items.Add("皮肤1");
            comboBox1.Items.Add("皮肤2");
            comboBox1.Items.Add("皮肤3");
            comboBox1.Items.Add("皮肤4");
            pictureBox8.MouseWheel += pictureBox8_MouseWheel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point p1 = MousePosition;
            Point p2 = PointToClient(p1);
            int X = p2.X;
            if (X > pictureBox6.Location.X && X < pictureBox6.Location.X + pictureBox6.Width) 
                pictureBox7.Location = new Point(X, pictureBox7.Location.Y);
            else if (X <= pictureBox6.Location.X)
                pictureBox7.Location = new Point(pictureBox6.Location.X, pictureBox7.Location.Y);
            else pictureBox7.Location = new Point(pictureBox6.Location.X + pictureBox6.Width, pictureBox7.Location.Y);
            double N = ((double)pictureBox7.Location.X - (double)pictureBox6.Location.X) / (double)pictureBox6.Width;
            label1.Text = ((int)(N * 100)).ToString();
            pictureBox8.Invalidate();
        }  // 控制透明度按钮拖动
        private Image background = Properties.Resources.大图背景;
        private Image mark_raw = null;
        private Bitmap mark_after = null;
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgFile = openFileDialog1.FileName;
                background = Image.FromFile(imgFile);// str为背景图片的路径
                backPl.BackgroundImage = new Bitmap(background, backPl.Size);
            }
        }  // 载入原始图片

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string imgFile = openFileDialog1.FileName;
                mark_raw = Image.FromFile(imgFile);// str为背景图片的路径
                pictureBox8.Width = mark_raw.Width;
                pictureBox8.Height = mark_raw.Height;
                pictureBox8.Invalidate();
            }
        }  // 载入水印图片

        private void ChangePictureAlpha(float colorAlpha)
        {
            mark_after = new Bitmap(pictureBox8.Width, pictureBox8.Height);
            Graphics g = Graphics.FromImage(mark_after);
            float[][] matrixItems ={
                new float[] {1, 0, 0, 0, 0},
                new float[] {0, 1, 0,0 , 0},
                new float[] {0, 0, 1, 0, 0},
                new float[] {0, 0, 0, colorAlpha, 0},
                new float[] {0, 0, 0, 0, 1}};
            ColorMatrix colorMatrix = new ColorMatrix(matrixItems);
            ImageAttributes imageAtt = new ImageAttributes();
            imageAtt.SetColorMatrix(colorMatrix,ColorMatrixFlag.Default,ColorAdjustType.Bitmap);
            Bitmap bitmap = new Bitmap(mark_raw, pictureBox8.Size);
            int iWidth = bitmap.Width;
            int iHeight = bitmap.Height;
            g.DrawImage(bitmap, new Rectangle(0, 0, iWidth, iHeight),0.0f,0.0f,iWidth,iHeight,GraphicsUnit.Pixel,imageAtt);
        }
        // 改变pictureBox中图片透明度
        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text != "")
            {
                if(comboBox1.Text == "皮肤1")
                {
                    this.BackgroundImage = Properties.Resources.皮肤1;
                }
                else if(comboBox1.Text == "皮肤2")
                {
                    this.BackgroundImage = Properties.Resources.皮肤2;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                }
                else if (comboBox1.Text == "皮肤3")
                {
                    this.BackgroundImage = Properties.Resources.皮肤3;
                }
                else if (comboBox1.Text == "皮肤4")
                {
                    this.BackgroundImage = Properties.Resources.皮肤4;
                }
            }
        }

        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            pictureBox8.Focus();
            pictureBox8.Cursor = Cursors.SizeAll;
        }
        //水印大小可缩放
        void pictureBox8_MouseWheel(object sender, MouseEventArgs e)
        {
            int i = e.Delta * SystemInformation.MouseWheelScrollLines / 5;

            pictureBox8.Width = pictureBox8.Width + i;//增加picturebox的宽度
            pictureBox8.Height = pictureBox8.Height + i;
            pictureBox8.Left = pictureBox8.Left - i / 2;//使picturebox的中心位于窗体的中心
            pictureBox8.Top = pictureBox8.Top - i / 2;//进而缩放时图片也位于窗体的中心
        }

        //水印透明
        private void pictureBox8_Paint(object sender, PaintEventArgs e)
        {
            if (mark_raw == null) return;
            ChangePictureAlpha(float.Parse(label1.Text) / 100.0f);
            Graphics g = e.Graphics;
            g.DrawImage(mark_after, new Point(0, 0));
        }
        //背景图片为back，保存到filename位置，方便批量水印
        private void saveTofile(Image back, string filename)
        {
            Bitmap bit = new Bitmap(back, back.Size);
            Graphics g = Graphics.FromImage(bit);
            g.DrawImage(mark_after, new Rectangle(pictureBox8.Location, mark_after.Size));
            bit.Save(filename, ImageFormat.Png);
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SaveFileDialog folder = new SaveFileDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                saveTofile(background, folder.FileName);
                MessageBox.Show("添加水印成功");
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;//该值确定是否可以选择多个文件
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filename in dialog.FileNames)
                {
                    Image image = Image.FromFile(filename);
                    //生成水印文件名
                    string savefilename = Path.GetDirectoryName(filename) + "\\" + Path.GetFileNameWithoutExtension(filename) + "_" + Path.GetExtension(filename);
                    saveTofile(new Bitmap(image, backPl.Size), savefilename);
                }
                MessageBox.Show("批量生产成功，以_区分");
            }
        }
    }
}
