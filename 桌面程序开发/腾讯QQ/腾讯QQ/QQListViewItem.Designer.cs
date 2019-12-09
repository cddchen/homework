namespace 腾讯QQ
{
    partial class QQListViewItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QQListViewItem));
            this.TimeLbl = new System.Windows.Forms.Label();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.NickNameLbl = new System.Windows.Forms.Label();
            this.icon = new 腾讯QQ.Icon();
            this.SuspendLayout();
            // 
            // TimeLbl
            // 
            this.TimeLbl.AutoSize = true;
            this.TimeLbl.Font = new System.Drawing.Font("苹方 中等", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLbl.ForeColor = System.Drawing.Color.DimGray;
            this.TimeLbl.Location = new System.Drawing.Point(218, 3);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(39, 17);
            this.TimeLbl.TabIndex = 7;
            this.TimeLbl.Text = "15:56";
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Font = new System.Drawing.Font("苹方 中等", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MessageLbl.ForeColor = System.Drawing.Color.DimGray;
            this.MessageLbl.Location = new System.Drawing.Point(59, 26);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(32, 17);
            this.MessageLbl.TabIndex = 6;
            this.MessageLbl.Text = "你好";
            // 
            // NickNameLbl
            // 
            this.NickNameLbl.AutoSize = true;
            this.NickNameLbl.Font = new System.Drawing.Font("苹方 中等", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NickNameLbl.Location = new System.Drawing.Point(58, 6);
            this.NickNameLbl.Name = "NickNameLbl";
            this.NickNameLbl.Size = new System.Drawing.Size(37, 20);
            this.NickNameLbl.TabIndex = 5;
            this.NickNameLbl.Text = "小王";
            // 
            // icon
            // 
            this.icon.icon = ((System.Drawing.Image)(resources.GetObject("icon.icon")));
            this.icon.Location = new System.Drawing.Point(8, 2);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(45, 45);
            this.icon.TabIndex = 8;
            this.icon.MouseEnter += new System.EventHandler(this.icon_MouseEnter);
            this.icon.MouseLeave += new System.EventHandler(this.icon_MouseLeave);
            // 
            // QQListViewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.icon);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.MessageLbl);
            this.Controls.Add(this.NickNameLbl);
            this.Name = "QQListViewItem";
            this.Size = new System.Drawing.Size(256, 50);
            this.Load += new System.EventHandler(this.QQListViewItem_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.QQListViewItem_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label MessageLbl;
        private System.Windows.Forms.Label NickNameLbl;
        private Icon icon;
    }
}
