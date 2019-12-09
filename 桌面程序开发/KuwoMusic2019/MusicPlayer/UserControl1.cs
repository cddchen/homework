using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent(); 
            singerImg = new Bitmap(Properties.Resources.defaultSingerImg, this.Width, this.Height);
        }
        Graphics g;
        int margin = 10;
        int angle = 0;
        int iconRotateAngle = 0;
        int curPosRadius = 10;
        private Bitmap singerImg = null;
        private bool isPlaying = false;
        int min, max, cur;

        public Image SingerImg { get => SingerImg; set => SingerImg = value; }

        private void UserControl1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            
            Rectangle rect = new Rectangle(margin, margin, this.Width - 2 * margin, this.Height - 2 * margin);

            Pen pen1 = new Pen(Brushes.Black, 8.0f);
            g.DrawEllipse(pen1, rect);

            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.RotateTransform((float)iconRotateAngle);
            g.TranslateTransform(-this.Width / 2, -this.Height / 2);

            TextureBrush icon = new TextureBrush(singerImg);
            g.FillEllipse(icon, rect);

            g.ResetTransform();
            g.Save();

            Pen pen2 = new Pen(Color.FromArgb(168, 186, 217), 8);
            g.DrawArc(pen2, rect, 270, angle);

            double r = this.Width / 2 - margin;
            double x = r * Math.Sin(angle / 180.0 * Math.PI);
            double y = r * Math.Cos(angle / 180.0 * Math.PI);

            int x1 = (int)(this.Width / 2 + x);
            int y1 = (int)(this.Height / 2 - y);

            g.FillEllipse(new SolidBrush(Color.FromArgb(168, 186, 217)),
                new RectangleF(x1 - curPosRadius, y1 - curPosRadius, 2 * curPosRadius, 2 * curPosRadius));

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            angle++; iconRotateAngle++;
            this.Invalidate();
        }
    }
}
