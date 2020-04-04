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
            this.label6 = new System.Windows.Forms.Label();
            this.tBRatioRight = new System.Windows.Forms.TrackBar();
            this.tBIterTimes = new System.Windows.Forms.TrackBar();
            this.tBLength = new System.Windows.Forms.TrackBar();
            this.tBAngleLeft = new System.Windows.Forms.TrackBar();
            this.tBAngleRight = new System.Windows.Forms.TrackBar();
            this.tBRatioLeft = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.treePanel.Size = new System.Drawing.Size(385, 527);
            this.treePanel.TabIndex = 0;
            this.treePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.TreePanel_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ratio right:";
            // 
            // tBRatioRight
            // 
            this.tBRatioRight.Location = new System.Drawing.Point(288, 313);
            this.tBRatioRight.Name = "tBRatioRight";
            this.tBRatioRight.Size = new System.Drawing.Size(279, 56);
            this.tBRatioRight.TabIndex = 6;
            this.tBRatioRight.Scroll += new System.EventHandler(this.TBRatioRight_Scroll);
            // 
            // tBIterTimes
            // 
            this.tBIterTimes.Location = new System.Drawing.Point(288, 3);
            this.tBIterTimes.Name = "tBIterTimes";
            this.tBIterTimes.Size = new System.Drawing.Size(279, 56);
            this.tBIterTimes.TabIndex = 1;
            this.tBIterTimes.Scroll += new System.EventHandler(this.TBIterTimes_Scroll);
            // 
            // tBLength
            // 
            this.tBLength.Location = new System.Drawing.Point(288, 65);
            this.tBLength.Name = "tBLength";
            this.tBLength.Size = new System.Drawing.Size(279, 56);
            this.tBLength.TabIndex = 2;
            this.tBLength.Scroll += new System.EventHandler(this.TBLength_Scroll);
            // 
            // tBAngleLeft
            // 
            this.tBAngleLeft.Location = new System.Drawing.Point(288, 127);
            this.tBAngleLeft.Name = "tBAngleLeft";
            this.tBAngleLeft.Size = new System.Drawing.Size(279, 56);
            this.tBAngleLeft.TabIndex = 3;
            this.tBAngleLeft.Scroll += new System.EventHandler(this.TBAngleLeft_Scroll);
            // 
            // tBAngleRight
            // 
            this.tBAngleRight.Location = new System.Drawing.Point(288, 189);
            this.tBAngleRight.Name = "tBAngleRight";
            this.tBAngleRight.Size = new System.Drawing.Size(279, 56);
            this.tBAngleRight.TabIndex = 4;
            this.tBAngleRight.Scroll += new System.EventHandler(this.TBAngleRight_Scroll);
            // 
            // tBRatioLeft
            // 
            this.tBRatioLeft.Location = new System.Drawing.Point(288, 251);
            this.tBRatioLeft.Name = "tBRatioLeft";
            this.tBRatioLeft.Size = new System.Drawing.Size(279, 56);
            this.tBRatioLeft.TabIndex = 5;
            this.tBRatioLeft.Scroll += new System.EventHandler(this.TBRatioLeft_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iteraion Times:";
            this.label1.Click += new System.EventHandler(this.TBRatioLeft_Scroll);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Angle left:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Angle right:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Length:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Ratio left:";
            // 
            // btnColor
            // 
            this.btnColor.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnColor.Location = new System.Drawing.Point(91, 375);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(103, 33);
            this.btnColor.TabIndex = 15;
            this.btnColor.Text = "Click to change color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(288, 375);
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
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tBAngleLeft, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tBIterTimes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnColor, 0, 6);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(570, 439);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 620);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

