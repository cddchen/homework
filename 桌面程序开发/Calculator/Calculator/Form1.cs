using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public enum BtState { Enter, Leave };
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Calculate cal;
        private Operation op;
        private bool isDisplayTemAns;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(227, 227, 227);
            cal = new Calculate();
            op = Operation.Null;
            isDisplayTemAns = false;
        }

        private void OnClick(object sender, EventArgs e)
        {
            string name = (sender as UserControl).Name;
            switch (name)
            {
                case "MemoryClear":
                    cal.MemoryClear();
                    break;
                case "MemoryAdd":
                    if (Calculate.checkInput(Ans.Text))
                        cal.MemoryAdd(Ans.Text);
                    else MessageBox.Show("输入不合法");
                    break;
                case "MemorySub":
                    if (Calculate.checkInput(Ans.Text))
                        cal.MemorySub(Ans.Text);
                    else MessageBox.Show("输入不合法");
                    cal.MemorySub(Ans.Text);
                    break;
                case "MemoryRead":
                    Ans.Text = cal.MemoryRead();
                    break;
                case "num0":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "0";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "0";
                        else Ans.Text += "0";
                    }
                    break;
                case "num1":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "1";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "1";
                        else Ans.Text += "1";
                    }
                    break;
                case "num2":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "2";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "2";
                        else Ans.Text += "2";
                    }
                    break;
                case "num3":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "3";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "3";
                        else Ans.Text += "3";
                    }
                    break;
                case "num4":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "4";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "4";
                        else Ans.Text += "4";
                    }
                    break;
                case "num5":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "5";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "5";
                        else Ans.Text += "5";
                    }
                    break;
                case "num6":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "6";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "6";
                        else Ans.Text += "6";
                    }
                    break;
                case "num7":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "7";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "7";
                        else Ans.Text += "7";
                    }
                    break;
                case "num8":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "8";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "8";
                        else Ans.Text += "8";
                    }
                    break;
                case "num9":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "9";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        if (Ans.Text == "0") Ans.Text = "9";
                        else Ans.Text += "9";
                    }
                    break;
                case "numPoint":
                    if (isDisplayTemAns)
                    {
                        Ans.Text = "0.";
                        isDisplayTemAns = false;
                    }
                    else
                    {
                        Ans.Text += ".";
                    }
                    break;
                case "AllClear":
                    cal.AllClear();
                    Ans.Text = "0";
                    break;
                case "PosOrNeg":
                    if (Calculate.checkInput(Ans.Text))
                        Ans.Text = cal.PosOrNeg();
                    else MessageBox.Show("输入不合法");
                    break;
                case "Div":
                    if (Calculate.checkInput(Ans.Text))
                    {
                        Ans.Text = cal.Cal(op, Ans.Text);
                        op = Operation.Div;
                        isDisplayTemAns = true;
                    }
                    else MessageBox.Show("输入不合法");
                    break;
                case "Mul":
                    if (Calculate.checkInput(Ans.Text))
                    {
                        Ans.Text = cal.Cal(op, Ans.Text);
                        op = Operation.Mul;
                        isDisplayTemAns = true;
                    }
                    else MessageBox.Show("输入不合法");
                    break;
                case "Add":
                    if (Calculate.checkInput(Ans.Text))
                    {
                        Ans.Text = cal.Cal(op, Ans.Text);
                        op = Operation.Add;
                        isDisplayTemAns = true;
                    }
                    else MessageBox.Show("输入不合法");
                    break;
                case "Sub":
                    if (Calculate.checkInput(Ans.Text))
                    {
                        Ans.Text = cal.Cal(op, Ans.Text);
                        op = Operation.Sub;
                        isDisplayTemAns = true;
                    }
                    else MessageBox.Show("输入不合法");
                    break;
                case "Equal":
                    if (Calculate.checkInput(Ans.Text))
                    {
                        Ans.Text = cal.Cal(op, Ans.Text);
                        op = Operation.Null;
                        isDisplayTemAns = true;
                    }
                    else MessageBox.Show("输入不合法");
                    break;
            }
        }
        #region 设置MouseEnter、MouseLeave
        private void Equal_MouseEnter(object sender, EventArgs e)
        {
            Equal.State = BtState.Enter;
            Equal.Invalidate();
        }

        private void Equal_MouseLeave(object sender, EventArgs e)
        {
            Equal.State = BtState.Leave;
            Equal.Invalidate();
        }

        private void Operation_MouseEnter(object sender, EventArgs e)
        {
            ((OperationButton)sender).State = BtState.Enter;
            ((OperationButton)sender).Invalidate();
        }

        private void Operation_MouseLeave(object sender, EventArgs e)
        {
            ((OperationButton)sender).State = BtState.Leave;
            ((OperationButton)sender).Invalidate();
        }

        private void Num_MouseLeave(object sender, EventArgs e)
        {
            ((NumButton)sender).State = BtState.Leave;
            ((NumButton)sender).Invalidate();
        }

        private void Num_MouseEnter(object sender, EventArgs e)
        {
            ((NumButton)sender).State = BtState.Enter;
            ((NumButton)sender).Invalidate();
        }

        private void Memory_MouseEnter(object sender, EventArgs e)
        {
            ((mTypeButton)sender).State = BtState.Enter;
            ((mTypeButton)sender).Invalidate();
        }

        private void Memory_MouseLeave(object sender, EventArgs e)
        {
            ((mTypeButton)sender).State = BtState.Leave;
            ((mTypeButton)sender).Invalidate();
        }
        #endregion
    }
}