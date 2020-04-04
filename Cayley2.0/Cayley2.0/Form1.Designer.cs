namespace Cayley2._0
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
            this.treePanel = new System.Windows.Forms.Panel();
            this.tBIterTimes = new System.Windows.Forms.TrackBar();
            this.tBLength = new System.Windows.Forms.TrackBar();
            this.tBAngleLeft = new System.Windows.Forms.TrackBar();
            this.tBAngleRight = new System.Windows.Forms.TrackBar();
            this.tBRatioLeft = new System.Windows.Forms.TrackBar();
            this.tBRatioRight = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBIterTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioRight)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treePanel
            // 
            this.treePanel.Controls.Add(this.label6);
            this.treePanel.Controls.Add(this.tBRatioRight);
            this.treePanel.Location = new System.Drawing.Point(25, 59);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(385, 357);
            this.treePanel.TabIndex = 0;
            this.treePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TreePanel_Paint);
            // 
            // tBIterTimes
            // 
            this.tBIterTimes.Location = new System.Drawing.Point(153, 20);
            this.tBIterTimes.Name = "tBIterTimes";
            this.tBIterTimes.Size = new System.Drawing.Size(104, 56);
            this.tBIterTimes.TabIndex = 1;
            this.tBIterTimes.Scroll += new System.EventHandler(this.TBIterTimes_Scroll);
            // 
            // tBLength
            // 
            this.tBLength.Location = new System.Drawing.Point(153, 82);
            this.tBLength.Name = "tBLength";
            this.tBLength.Size = new System.Drawing.Size(104, 56);
            this.tBLength.TabIndex = 2;
            this.tBLength.Scroll += new System.EventHandler(this.TBLength_Scroll);
            // 
            // tBAngleLeft
            // 
            this.tBAngleLeft.Location = new System.Drawing.Point(153, 144);
            this.tBAngleLeft.Name = "tBAngleLeft";
            this.tBAngleLeft.Size = new System.Drawing.Size(104, 56);
            this.tBAngleLeft.TabIndex = 3;
            this.tBAngleLeft.Scroll += new System.EventHandler(this.TBAngleLeft_Scroll);
            // 
            // tBAngleRight
            // 
            this.tBAngleRight.Location = new System.Drawing.Point(153, 216);
            this.tBAngleRight.Name = "tBAngleRight";
            this.tBAngleRight.Size = new System.Drawing.Size(104, 56);
            this.tBAngleRight.TabIndex = 4;
            this.tBAngleRight.Scroll += new System.EventHandler(this.TBAngleRight_Scroll);
            // 
            // tBRatioLeft
            // 
            this.tBRatioLeft.Location = new System.Drawing.Point(153, 278);
            this.tBRatioLeft.Name = "tBRatioLeft";
            this.tBRatioLeft.Size = new System.Drawing.Size(104, 56);
            this.tBRatioLeft.TabIndex = 5;
            this.tBRatioLeft.Scroll += new System.EventHandler(this.TBRatioLeft_Scroll);
            // 
            // tBRatioRight
            // 
            this.tBRatioRight.Location = new System.Drawing.Point(89, 377);
            this.tBRatioRight.Name = "tBRatioRight";
            this.tBRatioRight.Size = new System.Drawing.Size(104, 56);
            this.tBRatioRight.TabIndex = 6;
            this.tBRatioRight.Scroll += new System.EventHandler(this.TBRatioRight_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iteraion Times:";
            this.label1.Click += new System.EventHandler(this.TBRatioLeft_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Angle left:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Angle right:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ratio Left:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Length:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-20, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ratio right:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tBAngleLeft);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tBAngleRight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tBIterTimes);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tBRatioLeft);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tBLength);
            this.panel1.Location = new System.Drawing.Point(447, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 357);
            this.panel1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.treePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.treePanel.ResumeLayout(false);
            this.treePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tBIterTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioRight)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel treePanel;
        private System.Windows.Forms.TrackBar tBIterTimes;
        private System.Windows.Forms.TrackBar tBLength;
        private System.Windows.Forms.TrackBar tBAngleLeft;
        private System.Windows.Forms.TrackBar tBAngleRight;
        private System.Windows.Forms.TrackBar tBRatioLeft;
        private System.Windows.Forms.TrackBar tBRatioRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}

