namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Ans = new Calculator.Display();
            this.Equal = new Calculator.EqualButton();
            this.num0 = new Calculator.NumButton();
            this.numPoint = new Calculator.NumButton();
            this.num3 = new Calculator.NumButton();
            this.num2 = new Calculator.NumButton();
            this.num1 = new Calculator.NumButton();
            this.num6 = new Calculator.NumButton();
            this.num5 = new Calculator.NumButton();
            this.num4 = new Calculator.NumButton();
            this.num9 = new Calculator.NumButton();
            this.num8 = new Calculator.NumButton();
            this.num7 = new Calculator.NumButton();
            this.Add = new Calculator.OperationButton();
            this.Sub = new Calculator.OperationButton();
            this.Mul = new Calculator.OperationButton();
            this.Div = new Calculator.OperationButton();
            this.PosOrNeg = new Calculator.OperationButton();
            this.AllClear = new Calculator.OperationButton();
            this.MemoryRead = new Calculator.mTypeButton();
            this.MemorySub = new Calculator.mTypeButton();
            this.MemoryAdd = new Calculator.mTypeButton();
            this.MemoryClear = new Calculator.mTypeButton();
            this.SuspendLayout();
            // 
            // Ans
            // 
            this.Ans.Location = new System.Drawing.Point(2, 12);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(300, 64);
            this.Ans.TabIndex = 22;
            // 
            // Equal
            // 
            this.Equal.Location = new System.Drawing.Point(234, 283);
            this.Equal.Name = "Equal";
            this.Equal.Operation = "=";
            this.Equal.Size = new System.Drawing.Size(68, 94);
            this.Equal.State = Calculator.BtState.Leave;
            this.Equal.TabIndex = 21;
            this.Equal.Click += new System.EventHandler(this.OnClick);
            this.Equal.MouseEnter += new System.EventHandler(this.Equal_MouseEnter);
            this.Equal.MouseLeave += new System.EventHandler(this.Equal_MouseLeave);
            // 
            // num0
            // 
            this.num0.Location = new System.Drawing.Point(12, 333);
            this.num0.Name = "num0";
            this.num0.Operation = "0";
            this.num0.Size = new System.Drawing.Size(142, 44);
            this.num0.State = Calculator.BtState.Leave;
            this.num0.TabIndex = 20;
            this.num0.Click += new System.EventHandler(this.OnClick);
            this.num0.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num0.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // numPoint
            // 
            this.numPoint.Location = new System.Drawing.Point(160, 333);
            this.numPoint.Name = "numPoint";
            this.numPoint.Operation = ".";
            this.numPoint.Size = new System.Drawing.Size(68, 44);
            this.numPoint.State = Calculator.BtState.Leave;
            this.numPoint.TabIndex = 19;
            this.numPoint.Click += new System.EventHandler(this.OnClick);
            this.numPoint.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.numPoint.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num3
            // 
            this.num3.Location = new System.Drawing.Point(160, 283);
            this.num3.Name = "num3";
            this.num3.Operation = "3";
            this.num3.Size = new System.Drawing.Size(68, 44);
            this.num3.State = Calculator.BtState.Leave;
            this.num3.TabIndex = 18;
            this.num3.Click += new System.EventHandler(this.OnClick);
            this.num3.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num3.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(86, 283);
            this.num2.Name = "num2";
            this.num2.Operation = "2";
            this.num2.Size = new System.Drawing.Size(68, 44);
            this.num2.State = Calculator.BtState.Leave;
            this.num2.TabIndex = 17;
            this.num2.Click += new System.EventHandler(this.OnClick);
            this.num2.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num2.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(12, 283);
            this.num1.Name = "num1";
            this.num1.Operation = "1";
            this.num1.Size = new System.Drawing.Size(68, 44);
            this.num1.State = Calculator.BtState.Leave;
            this.num1.TabIndex = 16;
            this.num1.Click += new System.EventHandler(this.OnClick);
            this.num1.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num1.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num6
            // 
            this.num6.Location = new System.Drawing.Point(160, 233);
            this.num6.Name = "num6";
            this.num6.Operation = "6";
            this.num6.Size = new System.Drawing.Size(68, 44);
            this.num6.State = Calculator.BtState.Leave;
            this.num6.TabIndex = 15;
            this.num6.Click += new System.EventHandler(this.OnClick);
            this.num6.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num6.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num5
            // 
            this.num5.Location = new System.Drawing.Point(86, 233);
            this.num5.Name = "num5";
            this.num5.Operation = "5";
            this.num5.Size = new System.Drawing.Size(68, 44);
            this.num5.State = Calculator.BtState.Leave;
            this.num5.TabIndex = 14;
            this.num5.Click += new System.EventHandler(this.OnClick);
            this.num5.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num5.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num4
            // 
            this.num4.Location = new System.Drawing.Point(12, 233);
            this.num4.Name = "num4";
            this.num4.Operation = "4";
            this.num4.Size = new System.Drawing.Size(68, 44);
            this.num4.State = Calculator.BtState.Leave;
            this.num4.TabIndex = 13;
            this.num4.Click += new System.EventHandler(this.OnClick);
            this.num4.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num4.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num9
            // 
            this.num9.Location = new System.Drawing.Point(160, 183);
            this.num9.Name = "num9";
            this.num9.Operation = "9";
            this.num9.Size = new System.Drawing.Size(68, 44);
            this.num9.State = Calculator.BtState.Leave;
            this.num9.TabIndex = 12;
            this.num9.Click += new System.EventHandler(this.OnClick);
            this.num9.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num9.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num8
            // 
            this.num8.Location = new System.Drawing.Point(86, 183);
            this.num8.Name = "num8";
            this.num8.Operation = "8";
            this.num8.Size = new System.Drawing.Size(68, 44);
            this.num8.State = Calculator.BtState.Leave;
            this.num8.TabIndex = 11;
            this.num8.Click += new System.EventHandler(this.OnClick);
            this.num8.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num8.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // num7
            // 
            this.num7.Location = new System.Drawing.Point(12, 183);
            this.num7.Name = "num7";
            this.num7.Operation = "7";
            this.num7.Size = new System.Drawing.Size(68, 44);
            this.num7.State = Calculator.BtState.Leave;
            this.num7.TabIndex = 10;
            this.num7.Click += new System.EventHandler(this.OnClick);
            this.num7.MouseEnter += new System.EventHandler(this.Num_MouseEnter);
            this.num7.MouseLeave += new System.EventHandler(this.Num_MouseLeave);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(234, 233);
            this.Add.Name = "Add";
            this.Add.Operation = "+";
            this.Add.Size = new System.Drawing.Size(68, 44);
            this.Add.State = Calculator.BtState.Leave;
            this.Add.TabIndex = 9;
            this.Add.Click += new System.EventHandler(this.OnClick);
            this.Add.MouseEnter += new System.EventHandler(this.Operation_MouseEnter);
            this.Add.MouseLeave += new System.EventHandler(this.Operation_MouseLeave);
            // 
            // Sub
            // 
            this.Sub.Location = new System.Drawing.Point(234, 183);
            this.Sub.Name = "Sub";
            this.Sub.Operation = "-";
            this.Sub.Size = new System.Drawing.Size(68, 44);
            this.Sub.State = Calculator.BtState.Leave;
            this.Sub.TabIndex = 8;
            this.Sub.Click += new System.EventHandler(this.OnClick);
            this.Sub.MouseEnter += new System.EventHandler(this.Operation_MouseEnter);
            this.Sub.MouseLeave += new System.EventHandler(this.Operation_MouseLeave);
            // 
            // Mul
            // 
            this.Mul.Location = new System.Drawing.Point(234, 133);
            this.Mul.Name = "Mul";
            this.Mul.Operation = "*";
            this.Mul.Size = new System.Drawing.Size(68, 44);
            this.Mul.State = Calculator.BtState.Leave;
            this.Mul.TabIndex = 7;
            this.Mul.Click += new System.EventHandler(this.OnClick);
            this.Mul.MouseEnter += new System.EventHandler(this.Operation_MouseEnter);
            this.Mul.MouseLeave += new System.EventHandler(this.Operation_MouseLeave);
            // 
            // Div
            // 
            this.Div.Location = new System.Drawing.Point(160, 133);
            this.Div.Name = "Div";
            this.Div.Operation = "/";
            this.Div.Size = new System.Drawing.Size(68, 44);
            this.Div.State = Calculator.BtState.Leave;
            this.Div.TabIndex = 6;
            this.Div.Click += new System.EventHandler(this.OnClick);
            this.Div.MouseEnter += new System.EventHandler(this.Operation_MouseEnter);
            this.Div.MouseLeave += new System.EventHandler(this.Operation_MouseLeave);
            // 
            // PosOrNeg
            // 
            this.PosOrNeg.Location = new System.Drawing.Point(86, 133);
            this.PosOrNeg.Name = "PosOrNeg";
            this.PosOrNeg.Operation = "+/-";
            this.PosOrNeg.Size = new System.Drawing.Size(68, 44);
            this.PosOrNeg.State = Calculator.BtState.Leave;
            this.PosOrNeg.TabIndex = 5;
            this.PosOrNeg.Click += new System.EventHandler(this.OnClick);
            this.PosOrNeg.MouseEnter += new System.EventHandler(this.Operation_MouseEnter);
            this.PosOrNeg.MouseLeave += new System.EventHandler(this.Operation_MouseLeave);
            // 
            // AllClear
            // 
            this.AllClear.Location = new System.Drawing.Point(12, 133);
            this.AllClear.Name = "AllClear";
            this.AllClear.Operation = "AC";
            this.AllClear.Size = new System.Drawing.Size(68, 44);
            this.AllClear.State = Calculator.BtState.Leave;
            this.AllClear.TabIndex = 4;
            this.AllClear.Click += new System.EventHandler(this.OnClick);
            this.AllClear.MouseEnter += new System.EventHandler(this.Operation_MouseEnter);
            this.AllClear.MouseLeave += new System.EventHandler(this.Operation_MouseLeave);
            // 
            // MemoryRead
            // 
            this.MemoryRead.Location = new System.Drawing.Point(234, 83);
            this.MemoryRead.Name = "MemoryRead";
            this.MemoryRead.Operation = "mr";
            this.MemoryRead.Size = new System.Drawing.Size(68, 44);
            this.MemoryRead.State = Calculator.BtState.Leave;
            this.MemoryRead.TabIndex = 3;
            this.MemoryRead.Click += new System.EventHandler(this.OnClick);
            this.MemoryRead.MouseEnter += new System.EventHandler(this.Memory_MouseEnter);
            this.MemoryRead.MouseLeave += new System.EventHandler(this.Memory_MouseLeave);
            // 
            // MemorySub
            // 
            this.MemorySub.Location = new System.Drawing.Point(160, 83);
            this.MemorySub.Name = "MemorySub";
            this.MemorySub.Operation = "m-";
            this.MemorySub.Size = new System.Drawing.Size(68, 44);
            this.MemorySub.State = Calculator.BtState.Leave;
            this.MemorySub.TabIndex = 2;
            this.MemorySub.Click += new System.EventHandler(this.OnClick);
            this.MemorySub.MouseEnter += new System.EventHandler(this.Memory_MouseEnter);
            this.MemorySub.MouseLeave += new System.EventHandler(this.Memory_MouseLeave);
            // 
            // MemoryAdd
            // 
            this.MemoryAdd.Location = new System.Drawing.Point(86, 83);
            this.MemoryAdd.Name = "MemoryAdd";
            this.MemoryAdd.Operation = "m+";
            this.MemoryAdd.Size = new System.Drawing.Size(68, 44);
            this.MemoryAdd.State = Calculator.BtState.Leave;
            this.MemoryAdd.TabIndex = 1;
            this.MemoryAdd.Click += new System.EventHandler(this.OnClick);
            this.MemoryAdd.MouseEnter += new System.EventHandler(this.Memory_MouseEnter);
            this.MemoryAdd.MouseLeave += new System.EventHandler(this.Memory_MouseLeave);
            // 
            // MemoryClear
            // 
            this.MemoryClear.Location = new System.Drawing.Point(12, 83);
            this.MemoryClear.Name = "MemoryClear";
            this.MemoryClear.Operation = "mc";
            this.MemoryClear.Size = new System.Drawing.Size(68, 44);
            this.MemoryClear.State = Calculator.BtState.Leave;
            this.MemoryClear.TabIndex = 0;
            this.MemoryClear.Click += new System.EventHandler(this.OnClick);
            this.MemoryClear.MouseEnter += new System.EventHandler(this.Memory_MouseEnter);
            this.MemoryClear.MouseLeave += new System.EventHandler(this.Memory_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(306, 385);
            this.Controls.Add(this.Ans);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.numPoint);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Sub);
            this.Controls.Add(this.Mul);
            this.Controls.Add(this.Div);
            this.Controls.Add(this.PosOrNeg);
            this.Controls.Add(this.AllClear);
            this.Controls.Add(this.MemoryRead);
            this.Controls.Add(this.MemorySub);
            this.Controls.Add(this.MemoryAdd);
            this.Controls.Add(this.MemoryClear);
            this.MaximumSize = new System.Drawing.Size(322, 506);
            this.MinimumSize = new System.Drawing.Size(322, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private mTypeButton MemoryClear;
        private mTypeButton MemoryAdd;
        private mTypeButton MemorySub;
        private mTypeButton MemoryRead;
        private OperationButton AllClear;
        private OperationButton PosOrNeg;
        private OperationButton Div;
        private OperationButton Mul;
        private OperationButton Sub;
        private OperationButton Add;
        private NumButton num7;
        private NumButton num8;
        private NumButton num9;
        private NumButton num4;
        private NumButton num5;
        private NumButton num6;
        private NumButton num1;
        private NumButton num2;
        private NumButton num3;
        private NumButton numPoint;
        private NumButton num0;
        private EqualButton Equal;
        private Display Ans;
    }
}

