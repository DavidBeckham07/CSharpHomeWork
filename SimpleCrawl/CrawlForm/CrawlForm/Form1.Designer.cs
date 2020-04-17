namespace CrawlForm
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
            this.listBoxCrawl = new System.Windows.Forms.ListBox();
            this.btnBegin = new System.Windows.Forms.Button();
            this.textBoxStartUrl = new System.Windows.Forms.TextBox();
            this.labelUrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxCrawl
            // 
            this.listBoxCrawl.FormattingEnabled = true;
            this.listBoxCrawl.ItemHeight = 15;
            this.listBoxCrawl.Location = new System.Drawing.Point(50, 139);
            this.listBoxCrawl.Name = "listBoxCrawl";
            this.listBoxCrawl.Size = new System.Drawing.Size(618, 259);
            this.listBoxCrawl.TabIndex = 0;
            // 
            // btnBegin
            // 
            this.btnBegin.Location = new System.Drawing.Point(546, 70);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(75, 23);
            this.btnBegin.TabIndex = 1;
            this.btnBegin.Text = "开始";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.BtnBegin_Click);
            // 
            // textBoxStartUrl
            // 
            this.textBoxStartUrl.Location = new System.Drawing.Point(171, 68);
            this.textBoxStartUrl.Name = "textBoxStartUrl";
            this.textBoxStartUrl.Size = new System.Drawing.Size(329, 25);
            this.textBoxStartUrl.TabIndex = 2;
            // 
            // labelUrl
            // 
            this.labelUrl.AutoSize = true;
            this.labelUrl.Location = new System.Drawing.Point(47, 74);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(82, 15);
            this.labelUrl.TabIndex = 3;
            this.labelUrl.Text = "起始地址：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUrl);
            this.Controls.Add(this.textBoxStartUrl);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.listBoxCrawl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCrawl;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.TextBox textBoxStartUrl;
        private System.Windows.Forms.Label labelUrl;
    }
}

