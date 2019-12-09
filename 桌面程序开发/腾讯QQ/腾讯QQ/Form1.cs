using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 腾讯QQ
{
    public partial class Form1 : Form
    {
        public int currentCount = 0;
        public int flag = 0;
        Form2Weather Wea = new Form2Weather();
        public Form1()
        {
            m_aeroEnabled = false;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region MouseEnter、MouseLeave
        private void SignatureLbl_MouseEnter(object sender, EventArgs e)
        {
            SignatureLbl.BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void SignatureLbl_MouseLeave(object sender, EventArgs e)
        {
            SignatureLbl.BackColor = Color.Transparent;
        }

        private void FormCloseBt_MouseEnter(object sender, EventArgs e)
        {
            FormCloseBt.BackColor = Color.Red;
        }
        private void LblGray_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void LblGray_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).BackColor = Color.Transparent;
        }

        private void GrayButton_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(100, 255, 255, 255);
        }

        private void GrayButton_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void Black2Gray_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).ForeColor = Color.Black;
        }

        private void Black2Gray_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).ForeColor = Color.DarkGray;
        }

        private void Black2GrayLbl_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }

        private void Black2GrayLbl_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.DarkGray;
        }

        #endregion

        #region 消息、联系人、空间

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen mypen = new Pen(Color.WhiteSmoke,1);
            g.DrawLine(mypen, new Point(0, 179), new Point(375, 179));
            g.DrawLine(mypen, new Point(0, 515), new Point(375, 515));
        }

        private void pictureBox12_MouseClick(object sender, MouseEventArgs e)
        {
            MessegeLine.Visible = true;
            ContactLine.Visible = false;
            QZoneLine.Visible = false;
            MessagePanel.Visible = true;
            ContackPanel.Visible = false;
        }

        private void pictureBox13_MouseClick(object sender, MouseEventArgs e)
        {
            ContactLine.Visible = true;
            MessegeLine.Visible = false;
            QZoneLine.Visible = false;
            MessagePanel.Visible = false;
            ContackPanel.Visible = true;
        }

        private void pictureBox14_MouseClick(object sender, MouseEventArgs e)
        {
            QZoneLine.Visible = true;
            ContactLine.Visible = false;
            MessegeLine.Visible = false;
            MessagePanel.Visible = true;
            ContackPanel.Visible = false;
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            MessegeLine.Visible = true;
            ContactLine.Visible = false;
            QZoneLine.Visible = false;
            MessagePanel.Visible = true;
            ContackPanel.Visible = false;
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            ContactLine.Visible = true;
            MessegeLine.Visible = false;
            QZoneLine.Visible = false;
            MessagePanel.Visible = false;
            ContackPanel.Visible = true;
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            QZoneLine.Visible = true;
            ContactLine.Visible = false;
            MessegeLine.Visible = false;
            MessagePanel.Visible = true;
            ContackPanel.Visible = false;
        }


        #endregion

        #region 天气预报
        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            flag = 1;
            Wea.setLocation(this.Location, this.Width + 7);
            Wea.Show();
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start(); // 鼠标移开便开始计时
            flag = 0;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int X = MousePosition.X;
            int Y = MousePosition.Y;
            int num = 0;
            if (Wea.Location.X <= X && X <= Wea.Location.X + Wea.Width && Wea.Location.Y <= Y && Y <= Wea.Location.Y + Wea.Height)
                num = 1;
            currentCount += 1;
            if(currentCount == 1&&num == 0&&flag==0) // 1秒后关闭“天气”界面
            {
                timer1.Stop();
                Wea.Visible = false;
            }
            currentCount = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //设置Timer控件可用
            timer1.Enabled = false;
            //设置时间间隔（毫秒为单位）
            timer1.Interval = 1000;
            MessegeLine.Visible = true;
            ContactLine.Visible = false;
            QZoneLine.Visible = false;
            for (int i = 0; i < 4; ++i)
            {
                QQListViewItem item1 = new QQListViewItem();
                item1.Message = "一起吃饭吗？";
                item1.Icon = Properties.Resources.icon1;
                item1.NickName = "小红";
                item1.Time = "12:30";
                item1.Width = MessagePanel.Width - 20;
                item1.Location = new Point(MessagePanel.Location.X, MessagePanel.Controls.Count * item1.Height);
                MessagePanel.Controls.Add(item1);
                QQListViewItem item2 = new QQListViewItem();
                item2.Message = "工作完成了吗？";
                item2.Icon = Properties.Resources.icon2;
                item2.NickName = "老板";
                item2.Time = "12:10";
                item2.Width = MessagePanel.Width - 20;
                item2.Location = new Point(MessagePanel.Location.X, MessagePanel.Controls.Count * item2.Height);
                MessagePanel.Controls.Add(item2);
                QQListViewItem item3 = new QQListViewItem();
                item3.Message = "来玩游戏";
                item3.Icon = Properties.Resources.icon3;
                item3.NickName = "小王";
                item3.Time = "11:10";
                item3.Width = MessagePanel.Width - 20;
                item3.Location = new Point(MessagePanel.Location.X, MessagePanel.Controls.Count * item3.Height);
                MessagePanel.Controls.Add(item3);
                QQListViewItem item4 = new QQListViewItem();
                item4.Message = "在吗？";
                item4.Icon = Properties.Resources.icon4;
                item4.NickName = "王二";
                item4.Time = "10:20";
                item4.Width = MessagePanel.Width - 20;
                item4.Location = new Point(MessagePanel.Location.X, MessagePanel.Controls.Count * item4.Height);
                MessagePanel.Controls.Add(item4);
            }
        }
        #endregion

        #region 实现form可拖动
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private Point mouse_offset;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }
        #endregion

        #region 设置form阴影
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
        );
        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 1,
                            rightWidth = 1,
                            topHeight = 1
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);

                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }


        #endregion

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = (panel2.Visible ^ true);
        }
    }

}
