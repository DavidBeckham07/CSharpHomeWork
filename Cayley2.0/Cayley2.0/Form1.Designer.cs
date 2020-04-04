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
            this.labelRatioRight = new System.Windows.Forms.Label();
            this.tBRatioRight = new System.Windows.Forms.TrackBar();
            this.tBIterTimes = new System.Windows.Forms.TrackBar();
            this.tBLength = new System.Windows.Forms.TrackBar();
            this.tBAngleLeft = new System.Windows.Forms.TrackBar();
            this.tBAngleRight = new System.Windows.Forms.TrackBar();
            this.tBRatioLeft = new System.Windows.Forms.TrackBar();
            this.labelTimes = new System.Windows.Forms.Label();
            this.labelAngleLeft = new System.Windows.Forms.Label();
            this.labelAngleRight = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelRatioLeft = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.panelColor = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBIterTimes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioLeft)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treePanel
            // 
            this.treePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treePanel.Location = new System.Drawing.Point(37, 59);
            this.treePanel.Name = "treePanel";
            this.treePanel.Size = new System.Drawing.Size(385, 538);
            this.treePanel.TabIndex = 0;
            this.treePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TreePanel_Paint);
            // 
            // labelRatioRight
            // 
            this.labelRatioRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRatioRight.AutoSize = true;
            this.labelRatioRight.Location = new System.Drawing.Point(85, 333);
            this.labelRatioRight.Name = "labelRatioRight";
            this.labelRatioRight.Size = new System.Drawing.Size(103, 15);
            this.labelRatioRight.TabIndex = 12;
            this.labelRatioRight.Text = "Ratio right:";
            // 
            // tBRatioRight
            // 
            this.tBRatioRight.Location = new System.Drawing.Point(276, 313);
            this.tBRatioRight.Maximum = 35;
            this.tBRatioRight.Minimum = 5;
            this.tBRatioRight.Name = "tBRatioRight";
            this.tBRatioRight.Size = new System.Drawing.Size(268, 56);
            this.tBRatioRight.TabIndex = 6;
            this.tBRatioRight.Value = 5;
            this.tBRatioRight.Scroll += new System.EventHandler(this.TBRatioRight_Scroll);
            // 
            // tBIterTimes
            // 
            this.tBIterTimes.Location = new System.Drawing.Point(276, 3);
            this.tBIterTimes.Maximum = 20;
            this.tBIterTimes.Name = "tBIterTimes";
            this.tBIterTimes.Size = new System.Drawing.Size(268, 56);
            this.tBIterTimes.TabIndex = 1;
            this.tBIterTimes.Value = 5;
            this.tBIterTimes.Scroll += new System.EventHandler(this.TBIterTimes_Scroll);
            // 
            // tBLength
            // 
            this.tBLength.Location = new System.Drawing.Point(276, 65);
            this.tBLength.Maximum = 35;
            this.tBLength.Minimum = 10;
            this.tBLength.Name = "tBLength";
            this.tBLength.Size = new System.Drawing.Size(268, 56);
            this.tBLength.TabIndex = 2;
            this.tBLength.Value = 15;
            this.tBLength.Scroll += new System.EventHandler(this.TBLength_Scroll);
            // 
            // tBAngleLeft
            // 
            this.tBAngleLeft.Location = new System.Drawing.Point(276, 127);
            this.tBAngleLeft.Maximum = 35;
            this.tBAngleLeft.Minimum = 10;
            this.tBAngleLeft.Name = "tBAngleLeft";
            this.tBAngleLeft.Size = new System.Drawing.Size(268, 56);
            this.tBAngleLeft.TabIndex = 3;
            this.tBAngleLeft.Value = 15;
            this.tBAngleLeft.Scroll += new System.EventHandler(this.TBAngleLeft_Scroll);
            // 
            // tBAngleRight
            // 
            this.tBAngleRight.Location = new System.Drawing.Point(276, 189);
            this.tBAngleRight.Maximum = 35;
            this.tBAngleRight.Minimum = 10;
            this.tBAngleRight.Name = "tBAngleRight";
            this.tBAngleRight.Size = new System.Drawing.Size(268, 56);
            this.tBAngleRight.TabIndex = 4;
            this.tBAngleRight.Value = 15;
            this.tBAngleRight.Scroll += new System.EventHandler(this.TBAngleRight_Scroll);
            // 
            // tBRatioLeft
            // 
            this.tBRatioLeft.Location = new System.Drawing.Point(276, 251);
            this.tBRatioLeft.Maximum = 35;
            this.tBRatioLeft.Minimum = 10;
            this.tBRatioLeft.Name = "tBRatioLeft";
            this.tBRatioLeft.Size = new System.Drawing.Size(268, 56);
            this.tBRatioLeft.TabIndex = 5;
            this.tBRatioLeft.Value = 15;
            this.tBRatioLeft.Scroll += new System.EventHandler(this.TBRatioLeft_Scroll);
            // 
            // labelTimes
            // 
            this.labelTimes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimes.AutoSize = true;
            this.labelTimes.Location = new System.Drawing.Point(73, 23);
            this.labelTimes.Name = "labelTimes";
            this.labelTimes.Size = new System.Drawing.Size(127, 15);
            this.labelTimes.TabIndex = 7;
            this.labelTimes.Text = "Iteraion Times:";
            // 
            // labelAngleLeft
            // 
            this.labelAngleLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAngleLeft.AutoSize = true;
            this.labelAngleLeft.Location = new System.Drawing.Point(89, 147);
            this.labelAngleLeft.Name = "labelAngleLeft";
            this.labelAngleLeft.Size = new System.Drawing.Size(95, 15);
            this.labelAngleLeft.TabIndex = 8;
            this.labelAngleLeft.Text = "Angle left:";
            // 
            // labelAngleRight
            // 
            this.labelAngleRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAngleRight.AutoSize = true;
            this.labelAngleRight.Location = new System.Drawing.Point(85, 209);
            this.labelAngleRight.Name = "labelAngleRight";
            this.labelAngleRight.Size = new System.Drawing.Size(103, 15);
            this.labelAngleRight.TabIndex = 9;
            this.labelAngleRight.Text = "Angle right:";
            // 
            // labelLength
            // 
            this.labelLength.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(105, 85);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(63, 15);
            this.labelLength.TabIndex = 11;
            this.labelLength.Text = "Length:";
            // 
            // labelRatioLeft
            // 
            this.labelRatioLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelRatioLeft.AutoSize = true;
            this.labelRatioLeft.Location = new System.Drawing.Point(89, 271);
            this.labelRatioLeft.Name = "labelRatioLeft";
            this.labelRatioLeft.Size = new System.Drawing.Size(95, 15);
            this.labelRatioLeft.TabIndex = 14;
            this.labelRatioLeft.Text = "Ratio left:";
            // 
            // btnColor
            // 
            this.btnColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnColor.Location = new System.Drawing.Point(85, 375);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(103, 33);
            this.btnColor.TabIndex = 15;
            this.btnColor.Text = "Click to change color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(276, 375);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(55, 29);
            this.panelColor.TabIndex = 16;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panelColor, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.tBRatioRight, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tBRatioLeft, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tBAngleRight, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tBLength, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelLength, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBAngleLeft, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBIterTimes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAngleLeft, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAngleRight, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelRatioLeft, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelRatioRight, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnColor, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelTimes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(474, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(547, 450);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 631);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.treePanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBIterTimes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBAngleRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBRatioLeft)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Label labelTimes;
        private System.Windows.Forms.Label labelRatioRight;
        private System.Windows.Forms.Label labelAngleLeft;
        private System.Windows.Forms.Label labelAngleRight;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelRatioLeft;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

