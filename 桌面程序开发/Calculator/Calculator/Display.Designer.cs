namespace Calculator
{
    partial class Display
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.AnsBack = new System.Windows.Forms.PictureBox();
            this.LED = new System.Windows.Forms.Panel();
            this.Ans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AnsBack)).BeginInit();
            this.LED.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnsBack
            // 
            this.AnsBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnsBack.BackgroundImage")));
            this.AnsBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnsBack.Location = new System.Drawing.Point(2, 0);
            this.AnsBack.Name = "AnsBack";
            this.AnsBack.Size = new System.Drawing.Size(296, 62);
            this.AnsBack.TabIndex = 23;
            this.AnsBack.TabStop = false;
            // 
            // LED
            // 
            this.LED.BackColor = System.Drawing.Color.Transparent;
            this.LED.Controls.Add(this.Ans);
            this.LED.ForeColor = System.Drawing.Color.Transparent;
            this.LED.Location = new System.Drawing.Point(15, 13);
            this.LED.Name = "LED";
            this.LED.Size = new System.Drawing.Size(272, 45);
            this.LED.TabIndex = 25;
            // 
            // Ans
            // 
            this.Ans.AutoSize = true;
            this.Ans.BackColor = System.Drawing.Color.Transparent;
            this.Ans.Dock = System.Windows.Forms.DockStyle.Right;
            this.Ans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ans.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Ans.Location = new System.Drawing.Point(231, 0);
            this.Ans.Name = "Ans";
            this.Ans.Size = new System.Drawing.Size(41, 46);
            this.Ans.TabIndex = 23;
            this.Ans.Text = "0";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LED);
            this.Controls.Add(this.AnsBack);
            this.Name = "Display";
            this.Size = new System.Drawing.Size(300, 75);
            this.Load += new System.EventHandler(this.Display_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnsBack)).EndInit();
            this.LED.ResumeLayout(false);
            this.LED.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox AnsBack;
        private System.Windows.Forms.Panel LED;
        private System.Windows.Forms.Label Ans;
    }
}
