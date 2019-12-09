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
    public partial class QQListViewItem : UserControl
    {
        private Image image = Properties.Resources.dafault;
        private string name = "Default";
        private string message = "Default";
        private string time = "15:56";
        public Image Icon { get => image; set => image = value; }
        public String NickName { get => name; set => name = value; }
        public String Message { get => message; set => message = value; }

        public String Time { get => time; set => time = value; }
        public QQListViewItem()
        {
            InitializeComponent();
        }

        private void QQListViewItem_Load(object sender, EventArgs e)
        {
            icon.icon = image;
            icon.Invalidate();
            NickNameLbl.Text = name;
            MessageLbl.Text = message;
            TimeLbl.Text = time;
        }

        private void QQListViewItem_Paint(object sender, PaintEventArgs e)
        {
            icon.Invalidate();
        }
        UserItem item = new UserItem();
        bool flg = false;
        private void icon_MouseEnter(object sender, EventArgs e)
        {
            if (!flg)
            {
                flg = true;
                item.Nickname = NickName;
                item.Location = new Point(MousePosition.X - item.Width - 30, MousePosition.Y);
                item.Show();
            }
        }

        private void icon_MouseLeave(object sender, EventArgs e)
        {
            if (flg) { item.Hide(); flg = false; }
        }
    }
}
