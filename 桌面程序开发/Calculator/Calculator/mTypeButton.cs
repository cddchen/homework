using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Calculator
{
    public partial class mTypeButton : UserControl
    {
        private string text;
        private BtState state;
        public mTypeButton()
        {
            InitializeComponent();
        }
        public string Operation { get => text; set => text = value; }
        public BtState State { get => state; set => state = value; }
        private void mTypeButton_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Color begin_color = Color.FromArgb(95, 95, 95);
            Color end_color = Color.FromArgb(65, 65, 65);
            if (state == BtState.Enter)
            {
                begin_color = Color.FromArgb(150, 95, 95, 95);
                end_color = Color.FromArgb(150, 65, 65, 65);
            }
            Rectangle rect = new Rectangle(e.ClipRectangle.X + 1, e.ClipRectangle.Y + 1, e.ClipRectangle.Width - 2 <= 0 ? 1 : e.ClipRectangle.Width - 2, e.ClipRectangle.Height - 2 <= 0 ? 1 : e.ClipRectangle.Height - 2);
            int radius = 15;
            //绘制阴影
            RectangleF off = new Rectangle(e.ClipRectangle.X + 2, e.ClipRectangle.Y + 2, e.ClipRectangle.Width, e.ClipRectangle.Height);
            GraphicsPath sdpath = new GraphicsPath();
            sdpath.AddArc(off.X, off.Y, radius, radius, 180, 90);
            sdpath.AddArc(off.Width - radius, off.Y, radius, radius, 270, 90);
            sdpath.AddArc(off.Width - radius, off.Height - radius, radius, radius, 0, 90);
            sdpath.AddArc(off.X, off.Height - radius, radius, radius, 90, 90);
            sdpath.CloseAllFigures();
            Brush b = new SolidBrush(Color.FromArgb(80, 0, 0, 0));
            g.FillPath(b, sdpath);
            //绘制圆角
            LinearGradientBrush brush = new LinearGradientBrush(rect, begin_color, end_color, LinearGradientMode.Vertical);
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            gp.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            gp.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            gp.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            gp.CloseAllFigures();
            g.FillPath(brush, gp);
            //绘制显示文本
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            SolidBrush textbrush = new SolidBrush(Color.White);
            g.DrawString(text, new Font("圆体", 18), textbrush, rect, sf);
        }
    }
}
