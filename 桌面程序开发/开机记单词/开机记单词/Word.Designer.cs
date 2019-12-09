namespace 开机记单词
{
    partial class Word
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Word));
            this.mean1 = new System.Windows.Forms.Label();
            this.mean2 = new System.Windows.Forms.Label();
            this.mean3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MediaPlay1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.pronunciation = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Question = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlay1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pronunciation)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mean1
            // 
            this.mean1.BackColor = System.Drawing.Color.Transparent;
            this.mean1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mean1.ForeColor = System.Drawing.Color.White;
            this.mean1.Location = new System.Drawing.Point(31, 101);
            this.mean1.Name = "mean1";
            this.mean1.Size = new System.Drawing.Size(255, 23);
            this.mean1.TabIndex = 1;
            this.mean1.Text = "mean1";
            this.mean1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mean1.Visible = false;
            this.mean1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mean1_MouseClick);
            this.mean1.MouseEnter += new System.EventHandler(this.mean1_MouseEnter);
            this.mean1.MouseLeave += new System.EventHandler(this.mean1_MouseLeave);
            // 
            // mean2
            // 
            this.mean2.BackColor = System.Drawing.Color.Transparent;
            this.mean2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mean2.ForeColor = System.Drawing.Color.White;
            this.mean2.Location = new System.Drawing.Point(31, 138);
            this.mean2.Name = "mean2";
            this.mean2.Size = new System.Drawing.Size(255, 23);
            this.mean2.TabIndex = 2;
            this.mean2.Text = "mean2";
            this.mean2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mean2.Visible = false;
            this.mean2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mean2_MouseClick);
            this.mean2.MouseEnter += new System.EventHandler(this.mean2_MouseEnter);
            this.mean2.MouseLeave += new System.EventHandler(this.mean2_MouseLeave);
            // 
            // mean3
            // 
            this.mean3.BackColor = System.Drawing.Color.Transparent;
            this.mean3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mean3.ForeColor = System.Drawing.Color.White;
            this.mean3.Location = new System.Drawing.Point(26, 173);
            this.mean3.Name = "mean3";
            this.mean3.Size = new System.Drawing.Size(260, 27);
            this.mean3.TabIndex = 3;
            this.mean3.Text = "mean3";
            this.mean3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mean3.Visible = false;
            this.mean3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.mean3_MouseClick);
            this.mean3.MouseEnter += new System.EventHandler(this.mean3_MouseEnter);
            this.mean3.MouseLeave += new System.EventHandler(this.mean3_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            // 
            // MediaPlay1
            // 
            this.MediaPlay1.Enabled = true;
            this.MediaPlay1.Location = new System.Drawing.Point(14, 59);
            this.MediaPlay1.Name = "MediaPlay1";
            this.MediaPlay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlay1.OcxState")));
            this.MediaPlay1.Size = new System.Drawing.Size(39, 23);
            this.MediaPlay1.TabIndex = 5;
            this.MediaPlay1.Visible = false;
            // 
            // pronunciation
            // 
            this.pronunciation.BackColor = System.Drawing.Color.Transparent;
            this.pronunciation.Image = ((System.Drawing.Image)(resources.GetObject("pronunciation.Image")));
            this.pronunciation.Location = new System.Drawing.Point(251, 18);
            this.pronunciation.Name = "pronunciation";
            this.pronunciation.Size = new System.Drawing.Size(35, 35);
            this.pronunciation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pronunciation.TabIndex = 6;
            this.pronunciation.TabStop = false;
            this.pronunciation.Visible = false;
            this.pronunciation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pronunciation_MouseClick);
            this.pronunciation.MouseEnter += new System.EventHandler(this.pronunciation_MouseEnter);
            this.pronunciation.MouseLeave += new System.EventHandler(this.pronunciation_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Question);
            this.panel1.Location = new System.Drawing.Point(60, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 78);
            this.panel1.TabIndex = 7;
            // 
            // Question
            // 
            this.Question.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Question.BackColor = System.Drawing.Color.Transparent;
            this.Question.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Question.ForeColor = System.Drawing.Color.White;
            this.Question.Location = new System.Drawing.Point(3, 0);
            this.Question.MaximumSize = new System.Drawing.Size(180, 80);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(180, 78);
            this.Question.TabIndex = 3;
            this.Question.Text = "word";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Question.Visible = false;
            // 
            // Word
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pronunciation);
            this.Controls.Add(this.MediaPlay1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mean3);
            this.Controls.Add(this.mean2);
            this.Controls.Add(this.mean1);
            this.Name = "Word";
            this.Size = new System.Drawing.Size(300, 217);
            this.Load += new System.EventHandler(this.Word_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Word_MouseClick);
            this.MouseEnter += new System.EventHandler(this.Word_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Word_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlay1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pronunciation)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label mean1;
        private System.Windows.Forms.Label mean2;
        private System.Windows.Forms.Label mean3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlay1;
        private System.Windows.Forms.PictureBox pronunciation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Question;
    }
}
