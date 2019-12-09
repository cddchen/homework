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
    public partial class FormDesk : Form
    {
        public FormDesk()
        {
            InitializeComponent();
        }

        private void FormDesk_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
