using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }
        public new string Text
        {
            set { Ans.Text = value; }
            get { return Ans.Text; }
        }

        private void Display_Load(object sender, EventArgs e)
        {
            Ans.BackColor = Color.FromArgb(203, 205, 178);
            LED.BackColor = Color.FromArgb(203, 205, 178);
            Ans.Font = new Font("DigifaceWide", 24);
        }
    }
}
