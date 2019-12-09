using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Image imgOriginal;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\cdd13\Desktop\桌面程序开发\图像处理";
            openFileDialog.Filter = "图片文件(*.jpg)|*.jpg";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgOriginal = Image.FromFile(openFileDialog.FileName);
                pictureBox1.BackgroundImage = imgOriginal;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(imgOriginal);
            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    Color color = bitmap.GetPixel(i, j);
                    int x = (color.R + color.G + color.B) / 3;
                    Color new_color = Color.FromArgb(x, x, x);

                    bitmap.SetPixel(i, j, new_color);
                }
            }
            pictureBox2.BackgroundImage = bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(imgOriginal);
            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    Color color = bitmap.GetPixel(i, j);
                    Color new_color = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);

                    bitmap.SetPixel(i, j, new_color);
                }
            }
            pictureBox2.BackgroundImage = bitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Bitmap bitmap = new Bitmap(imgOriginal);
            for (int i = 0; i < bitmap.Width; ++i)
            {
                for (int j = 0; j < bitmap.Height; ++j)
                {
                    int x = i + random.Next() % 20;
                    int y = j + random.Next() % 20;
                    if (x >= bitmap.Width - 1)
                        x = bitmap.Width - 1;
                    if (y >= bitmap.Height - 1)
                        y = bitmap.Height - 1;

                    bitmap.SetPixel(i, j, bitmap.GetPixel(x, y));
                }
            }
            pictureBox2.BackgroundImage = bitmap;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(imgOriginal);
            Color pixel1, pixel2;
            for (int i = 0; i < bitmap.Width - 1; ++i)
            {
                for (int j = 0; j < bitmap.Height - 1; ++j)
                {
                    int r, g, b;
                    pixel1 = bitmap.GetPixel(i, j);
                    pixel2 = bitmap.GetPixel(i + 1, j + 1);
                    
                    r = Math.Abs(pixel1.R - pixel2.R + 128) > 255 ? 255 : Math.Abs(pixel1.R - pixel2.R + 128);
                    g = Math.Abs(pixel1.G - pixel2.G + 128) > 255 ? 255 : Math.Abs(pixel1.G - pixel2.G + 128);
                    b = Math.Abs(pixel1.B - pixel2.B + 128) > 255 ? 255 : Math.Abs(pixel1.B - pixel2.B + 128);

                    bitmap.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            pictureBox2.BackgroundImage = bitmap;
        }
    }
}
