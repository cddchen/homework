namespace 腾讯QQ
{
    partial class Form2Weather
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2Weather));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TodayDegree = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.weather = new System.Windows.Forms.Label();
            this.airCondition = new System.Windows.Forms.Label();
            this.WeaBackTrans = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.afterdayWea = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tomWea = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.todayWea = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerCheckIfo = new System.Windows.Forms.Timer(this.components);
            this.WeaBackTrans.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TodayDegree
            // 
            this.TodayDegree.AutoSize = true;
            this.TodayDegree.BackColor = System.Drawing.Color.Transparent;
            this.TodayDegree.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayDegree.ForeColor = System.Drawing.Color.White;
            this.TodayDegree.Location = new System.Drawing.Point(6, 6);
            this.TodayDegree.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TodayDegree.Name = "TodayDegree";
            this.TodayDegree.Size = new System.Drawing.Size(58, 44);
            this.TodayDegree.TabIndex = 4;
            this.TodayDegree.Text = "度";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "°C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "成都(当地)";
            // 
            // weather
            // 
            this.weather.AutoSize = true;
            this.weather.BackColor = System.Drawing.Color.Transparent;
            this.weather.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.weather.ForeColor = System.Drawing.Color.White;
            this.weather.Location = new System.Drawing.Point(10, 72);
            this.weather.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.weather.Name = "weather";
            this.weather.Size = new System.Drawing.Size(65, 20);
            this.weather.TabIndex = 7;
            this.weather.Text = "天气状况";
            // 
            // airCondition
            // 
            this.airCondition.AutoSize = true;
            this.airCondition.BackColor = System.Drawing.Color.Transparent;
            this.airCondition.Font = new System.Drawing.Font("微软雅黑", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.airCondition.ForeColor = System.Drawing.Color.White;
            this.airCondition.Location = new System.Drawing.Point(10, 92);
            this.airCondition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.airCondition.Name = "airCondition";
            this.airCondition.Size = new System.Drawing.Size(65, 20);
            this.airCondition.TabIndex = 8;
            this.airCondition.Text = "空气状况";
            // 
            // WeaBackTrans
            // 
            this.WeaBackTrans.BackColor = System.Drawing.Color.Transparent;
            this.WeaBackTrans.Controls.Add(this.panel3);
            this.WeaBackTrans.Controls.Add(this.panel2);
            this.WeaBackTrans.Controls.Add(this.panel1);
            this.WeaBackTrans.ForeColor = System.Drawing.Color.Transparent;
            this.WeaBackTrans.Location = new System.Drawing.Point(1, 135);
            this.WeaBackTrans.Name = "WeaBackTrans";
            this.WeaBackTrans.Size = new System.Drawing.Size(233, 113);
            this.WeaBackTrans.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.afterdayWea);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label10);
            this.panel3.ForeColor = System.Drawing.Color.Transparent;
            this.panel3.Location = new System.Drawing.Point(156, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(76, 82);
            this.panel3.TabIndex = 22;
            // 
            // afterdayWea
            // 
            this.afterdayWea.AutoSize = true;
            this.afterdayWea.BackColor = System.Drawing.Color.Transparent;
            this.afterdayWea.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.afterdayWea.ForeColor = System.Drawing.Color.Transparent;
            this.afterdayWea.Location = new System.Drawing.Point(5, 18);
            this.afterdayWea.Name = "afterdayWea";
            this.afterdayWea.Size = new System.Drawing.Size(52, 16);
            this.afterdayWea.TabIndex = 14;
            this.afterdayWea.Text = "后天天气";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(27, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "后天";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.tomWea);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label8);
            this.panel2.ForeColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(78, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(76, 82);
            this.panel2.TabIndex = 21;
            // 
            // tomWea
            // 
            this.tomWea.AutoSize = true;
            this.tomWea.BackColor = System.Drawing.Color.Transparent;
            this.tomWea.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.tomWea.ForeColor = System.Drawing.Color.Transparent;
            this.tomWea.Location = new System.Drawing.Point(5, 18);
            this.tomWea.Name = "tomWea";
            this.tomWea.Size = new System.Drawing.Size(52, 16);
            this.tomWea.TabIndex = 14;
            this.tomWea.Text = "明天温度";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "明天";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.todayWea);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.today);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 82);
            this.panel1.TabIndex = 20;
            // 
            // todayWea
            // 
            this.todayWea.AutoSize = true;
            this.todayWea.BackColor = System.Drawing.Color.Transparent;
            this.todayWea.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.todayWea.ForeColor = System.Drawing.Color.Transparent;
            this.todayWea.Location = new System.Drawing.Point(5, 18);
            this.todayWea.Name = "todayWea";
            this.todayWea.Size = new System.Drawing.Size(52, 16);
            this.todayWea.TabIndex = 14;
            this.todayWea.Text = "今天温度";
            // 
            // today
            // 
            this.today.AutoSize = true;
            this.today.BackColor = System.Drawing.Color.Transparent;
            this.today.Font = new System.Drawing.Font("微软雅黑", 8F);
            this.today.ForeColor = System.Drawing.Color.White;
            this.today.Location = new System.Drawing.Point(27, 0);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(30, 16);
            this.today.TabIndex = 12;
            this.today.Text = "今天";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::腾讯QQ.Properties.Resources.多云;
            this.pictureBox2.Location = new System.Drawing.Point(17, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::腾讯QQ.Properties.Resources.多云;
            this.pictureBox3.Location = new System.Drawing.Point(17, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(17, 42);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(204, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // timerCheckIfo
            // 
            this.timerCheckIfo.Enabled = true;
            this.timerCheckIfo.Tick += new System.EventHandler(this.timerCheckIfo_Tick);
            // 
            // Form2Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(234, 247);
            this.Controls.Add(this.WeaBackTrans);
            this.Controls.Add(this.airCondition);
            this.Controls.Add(this.weather);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TodayDegree);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(917, 135);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2Weather";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2Weather";
            this.Load += new System.EventHandler(this.Form2Weather_Load);
            this.MouseEnter += new System.EventHandler(this.Form2Weather_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form2Weather_MouseLeave);
            this.WeaBackTrans.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TodayDegree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weather;
        private System.Windows.Forms.Label airCondition;
        private System.Windows.Forms.Panel WeaBackTrans;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label afterdayWea;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label tomWea;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label todayWea;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label today;
        private System.Windows.Forms.Timer timerCheckIfo;
    }
}