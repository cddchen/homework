using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 腾讯QQ
{
    public partial class Icon : UserControl
    {
        private Image image = Properties.Resources.dafault;
        public Image icon { get => image; set => image = value; }
        public Icon()
        {
            InitializeComponent();
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Rectangle rect = e.ClipRectangle;
            TextureBrush icon = new TextureBrush(new Bitmap(image, new Size(this.Width, this.Height)));
            g.FillEllipse(icon, rect);
        }
    }
}
