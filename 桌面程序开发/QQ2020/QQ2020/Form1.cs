using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QQ2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(19, 194, 253);
        }

        private void form_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void form_close_MouseEnter(object sender, EventArgs e)
        {
            form_close.BackColor = Color.Red;
        }

        private void form_close_MouseLeave(object sender, EventArgs e)
        {
            form_close.BackColor = Color.Transparent;
        }

        private Point mouse_offset;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                Location = mousePos;
            }
        }

        private void GrayButton_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.FromArgb(50, 255, 255, 255);
        }

        private void GrayButton_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Transparent;
        }

        private void GrayLabel_MouseEnter(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(100, 100, 100);
        }

        private void GrayLabel_MouseLeave(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.FromArgb(131, 131, 131);
        }

        private void HeadIcon_MouseEnter(object sender, EventArgs e)
        {
            if (!AddLoginMove.Enabled)
            {
                AddLoginMove.Enabled = true;
                AddLoginMove.Start();
            }
        }

        private void AddLoginMove_Tick(object sender, EventArgs e)
        {
            if (AddNewLoginBt.Location.X - HeadIcon.Location.X < 80)
            {
                AddNewLoginBt.Location = new Point(AddNewLoginBt.Location.X + 3, AddNewLoginBt.Location.Y);
            }
        }

        private void HeadIcon_MouseLeave(object sender, EventArgs e)
        {
            if (!AddLoginBack.Enabled)
            {
                AddLoginBack.Enabled = true;
                AddLoginBack.Start();
            }
        }

        private void AddLoginBack_Tick(object sender, EventArgs e)
        {
            if (AddLoginMove.Enabled && AddNewLoginBt.Location.X - HeadIcon.Location.X >= 80)
            {
                AddLoginMove.Stop();
                AddLoginMove.Enabled = false;
            }
            if (!AddLoginMove.Enabled && AddNewLoginBt.Location.X - HeadIcon.Location.X > 20)
            {
                AddNewLoginBt.Location = new Point(AddNewLoginBt.Location.X - 3, AddNewLoginBt.Location.Y);
            }
            if (!AddLoginMove.Enabled && AddNewLoginBt.Location.X - HeadIcon.Location.X <= 20)
            {
                AddLoginBack.Stop();
                AddLoginBack.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FormMain fm = new FormMain();
            fm.ShowDialog();
        }
    }
}
