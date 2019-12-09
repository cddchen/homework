using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 开机记单词
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //加入开机自启项
            try
            {
                string path = Application.ExecutablePath;
                RegistryKey rk = Registry.LocalMachine;
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");
                rk2.SetValue("开机记单词", path);
                rk2.Close();
                rk.Close();
            }
            catch (Exception ex) { }
            timer1.Enabled = true;
            timer1.Start(); // 鼠标移开便开始计时
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(word1.returnFlag() == 2&&word2.returnFlag() == 2&&word3.returnFlag() == 2 && word4.returnFlag() == 2 && word5.returnFlag() == 2 && word6.returnFlag() == 2 && word7.returnFlag() == 2 && word8.returnFlag() == 2 && word9.returnFlag() == 2 && word10.returnFlag() == 2 && word11.returnFlag() == 2 && word12.returnFlag() == 2 && word13.returnFlag() == 2 && word14.returnFlag() == 2 && word15.returnFlag() == 2)
            {
                panel1.Visible = false;
                timer1.Stop();
                MessageBox.Show("恭喜您完成单词测试，即将开机~");
                this.Close();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //屏蔽alt+f4
            if (e.KeyCode == Keys.F4 && e.Modifiers == Keys.Alt)
            {
                e.Handled = true;
            }
        }
    }
}
