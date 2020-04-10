namespace OrderSystemForm
{
    partial class MainForm
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
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.TotalSum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.modifyOrderBtn = new System.Windows.Forms.Button();
            this.fieldComboBox = new System.Windows.Forms.ComboBox();
            this.importBtn = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.exportBtn = new System.Windows.Forms.Button();
            this.SearchOrderBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnBtn = new System.Windows.Forms.Button();
            this.xmlSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.xmlOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.buttomTableLayoutPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AllowUserToOrderColumns = true;
            this.orderDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.orderDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Client,
            this.totalSumDataGridViewTextBoxColumn});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 100);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 100;
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(403, 189);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.itemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.itemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.TotalSum});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(412, 100);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 51;
            this.itemDataGridView.RowTemplate.Height = 27;
            this.itemDataGridView.Size = new System.Drawing.Size(573, 189);
            this.itemDataGridView.TabIndex = 1;
            // 
            // TotalSum
            // 
            this.TotalSum.DataPropertyName = "TotalSum";
            this.TotalSum.HeaderText = "TotalSum";
            this.TotalSum.MinimumWidth = 6;
            this.TotalSum.Name = "TotalSum";
            this.TotalSum.ReadOnly = true;
            this.TotalSum.Width = 85;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Items";
            this.itemBindingSource.DataSource = this.orderBindingSource;
            // 
            // buttomTableLayoutPanel
            // 
            this.buttomTableLayoutPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttomTableLayoutPanel.ColumnCount = 2;
            this.buttomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.44869F));
            this.buttomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.55131F));
            this.buttomTableLayoutPanel.Controls.Add(this.orderDataGridView, 0, 0);
            this.buttomTableLayoutPanel.Controls.Add(this.itemDataGridView, 1, 0);
            this.buttomTableLayoutPanel.Location = new System.Drawing.Point(6, 100);
            this.buttomTableLayoutPanel.Name = "buttomTableLayoutPanel";
            this.buttomTableLayoutPanel.RowCount = 1;
            this.buttomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttomTableLayoutPanel.Size = new System.Drawing.Size(988, 390);
            this.buttomTableLayoutPanel.TabIndex = 2;
            this.buttomTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtomTableLayoutPanel_Paint);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.buttomTableLayoutPanel);
            this.mainPanel.Location = new System.Drawing.Point(12, -32);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(994, 492);
            this.mainPanel.TabIndex = 3;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.Location = new System.Drawing.Point(250, 3);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(150, 25);
            this.addOrderBtn.TabIndex = 0;
            this.addOrderBtn.Text = "添加订单";
            this.addOrderBtn.UseVisualStyleBackColor = true;
            this.addOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
            // 
            // modifyOrderBtn
            // 
            this.modifyOrderBtn.Location = new System.Drawing.Point(3, 3);
            this.modifyOrderBtn.Name = "modifyOrderBtn";
            this.modifyOrderBtn.Size = new System.Drawing.Size(150, 25);
            this.modifyOrderBtn.TabIndex = 1;
            this.modifyOrderBtn.Text = "修改订单";
            this.modifyOrderBtn.UseVisualStyleBackColor = true;
            this.modifyOrderBtn.Click += new System.EventHandler(this.ModifyOrderBtn_Click);
            // 
            // fieldComboBox
            // 
            this.fieldComboBox.FormattingEnabled = true;
            this.fieldComboBox.Items.AddRange(new object[] {
            "ID",
            "Client"});
            this.fieldComboBox.Location = new System.Drawing.Point(3, 50);
            this.fieldComboBox.Name = "fieldComboBox";
            this.fieldComboBox.Size = new System.Drawing.Size(121, 23);
            this.fieldComboBox.TabIndex = 7;
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(497, 3);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(150, 25);
            this.importBtn.TabIndex = 5;
            this.importBtn.Text = "导入订单";
            this.importBtn.UseVisualStyleBackColor = true;
            this.importBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(250, 50);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(144, 25);
            this.valueTextBox.TabIndex = 4;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(744, 3);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(150, 25);
            this.exportBtn.TabIndex = 6;
            this.exportBtn.Text = "导出订单";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // SearchOrderBtn
            // 
            this.SearchOrderBtn.Location = new System.Drawing.Point(497, 50);
            this.SearchOrderBtn.Name = "SearchOrderBtn";
            this.SearchOrderBtn.Size = new System.Drawing.Size(150, 25);
            this.SearchOrderBtn.TabIndex = 2;
            this.SearchOrderBtn.Text = "查找";
            this.SearchOrderBtn.UseVisualStyleBackColor = true;
            this.SearchOrderBtn.Click += new System.EventHandler(this.SearchOrderBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(744, 50);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(150, 25);
            this.returnBtn.TabIndex = 8;
            this.returnBtn.Text = "返回";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.ReturnBtn_Click);
            // 
            // xmlOpenFileDialog
            // 
            this.xmlOpenFileDialog.FileName = "openFileDialog1";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderSystem.Order);
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "goodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "goodName";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNameDataGridViewTextBoxColumn.Width = 85;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "goodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "goodPrice";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodPriceDataGridViewTextBoxColumn.Width = 85;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 85;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.returnBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.modifyOrderBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.addOrderBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.importBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.SearchOrderBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.exportBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.valueTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.fieldComboBox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(991, 95);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 75;
            // 
            // Client
            // 
            this.Client.DataPropertyName = "Client";
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.Width = 75;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            this.totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSumDataGridViewTextBoxColumn.Width = 75;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 598);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mainPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.buttomTableLayoutPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.TableLayoutPanel buttomTableLayoutPanel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button addOrderBtn;
        private System.Windows.Forms.Button modifyOrderBtn;
        private System.Windows.Forms.Button SearchOrderBtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox fieldComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSum;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.SaveFileDialog xmlSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog xmlOpenFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
    }
}

