namespace ClipboardMonitor
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TbClipboardContent = new System.Windows.Forms.TextBox();
            this.TmMonitor = new System.Windows.Forms.Timer(this.components);
            this.BtStartMonitor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbClipboardContent
            // 
            this.TbClipboardContent.Location = new System.Drawing.Point(12, 81);
            this.TbClipboardContent.Multiline = true;
            this.TbClipboardContent.Name = "TbClipboardContent";
            this.TbClipboardContent.Size = new System.Drawing.Size(199, 161);
            this.TbClipboardContent.TabIndex = 0;
            // 
            // TmMonitor
            // 
            this.TmMonitor.Tick += new System.EventHandler(this.TmMonitor_Tick);
            // 
            // BtStartMonitor
            // 
            this.BtStartMonitor.Location = new System.Drawing.Point(321, 22);
            this.BtStartMonitor.Name = "BtStartMonitor";
            this.BtStartMonitor.Size = new System.Drawing.Size(118, 23);
            this.BtStartMonitor.TabIndex = 1;
            this.BtStartMonitor.Text = "监视：false";
            this.BtStartMonitor.UseVisualStyleBackColor = true;
            this.BtStartMonitor.Click += new System.EventHandler(this.BtStartMonitor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(235, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 161);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 254);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtStartMonitor);
            this.Controls.Add(this.TbClipboardContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbClipboardContent;
        private System.Windows.Forms.Timer TmMonitor;
        private System.Windows.Forms.Button BtStartMonitor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

