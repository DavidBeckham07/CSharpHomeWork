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
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.orderdbDataSet = new OrderSystemForm.orderdbDataSet();
            this.ordersTableAdapter = new OrderSystemForm.orderdbDataSetTableAdapters.ordersTableAdapter();
            this.orderitemsTableAdapter = new OrderSystemForm.orderdbDataSetTableAdapters.orderitemsTableAdapter();
            this.good_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.good_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdbDataSet1 = new OrderSystemForm.orderdbDataSet1();
            this.ordersTableAdapter1 = new OrderSystemForm.orderdbDataSet1TableAdapters.ordersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.buttomTableLayoutPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet1)).BeginInit();
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
            this.orderIdDataGridViewTextBoxColumn1,
            this.clientDataGridViewTextBoxColumn1,
            this.totalSumDataGridViewTextBoxColumn1});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(3, 100);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.RowHeadersWidth = 100;
            this.orderDataGridView.RowTemplate.Height = 27;
            this.orderDataGridView.Size = new System.Drawing.Size(403, 189);
            this.orderDataGridView.TabIndex = 0;
            this.orderDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "orders";
            this.orderBindingSource.DataSource = this.orderdbDataSet1;
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
            this.good_Name,
            this.good_Price,
            this.Number,
            this.totalSumDataGridViewTextBoxColumn});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(412, 100);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 51;
            this.itemDataGridView.RowTemplate.Height = 27;
            this.itemDataGridView.Size = new System.Drawing.Size(573, 189);
            this.itemDataGridView.TabIndex = 1;
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataMember = "Order_Items";
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
            // orderdbDataSet
            // 
            this.orderdbDataSet.DataSetName = "orderdbDataSet";
            this.orderdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // orderitemsTableAdapter
            // 
            this.orderitemsTableAdapter.ClearBeforeFill = true;
            // 
            // good_Name
            // 
            this.good_Name.DataPropertyName = "good_Name";
            this.good_Name.HeaderText = "good_Name";
            this.good_Name.MinimumWidth = 6;
            this.good_Name.Name = "good_Name";
            this.good_Name.Width = 125;
            // 
            // good_Price
            // 
            this.good_Price.DataPropertyName = "good_Price";
            this.good_Price.HeaderText = "good_Price";
            this.good_Price.MinimumWidth = 6;
            this.good_Price.Name = "good_Price";
            this.good_Price.Width = 125;
            // 
            // Number
            // 
            this.Number.DataPropertyName = "Number";
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.Width = 125;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            this.totalSumDataGridViewTextBoxColumn.Width = 125;
            // 
            // orderIdDataGridViewTextBoxColumn1
            // 
            this.orderIdDataGridViewTextBoxColumn1.DataPropertyName = "OrderId";
            this.orderIdDataGridViewTextBoxColumn1.HeaderText = "OrderId";
            this.orderIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.orderIdDataGridViewTextBoxColumn1.Name = "orderIdDataGridViewTextBoxColumn1";
            // 
            // clientDataGridViewTextBoxColumn1
            // 
            this.clientDataGridViewTextBoxColumn1.DataPropertyName = "Client";
            this.clientDataGridViewTextBoxColumn1.HeaderText = "Client";
            this.clientDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.clientDataGridViewTextBoxColumn1.Name = "clientDataGridViewTextBoxColumn1";
            // 
            // totalSumDataGridViewTextBoxColumn1
            // 
            this.totalSumDataGridViewTextBoxColumn1.DataPropertyName = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn1.HeaderText = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.totalSumDataGridViewTextBoxColumn1.Name = "totalSumDataGridViewTextBoxColumn1";
            this.totalSumDataGridViewTextBoxColumn1.Width = 125;
            // 
            // orderdbDataSet1
            // 
            this.orderdbDataSet1.DataSetName = "orderdbDataSet1";
            this.orderdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordersTableAdapter1
            // 
            this.ordersTableAdapter1.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.buttomTableLayoutPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderdbDataSet1)).EndInit();
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
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.SaveFileDialog xmlSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog xmlOpenFileDialog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private orderdbDataSet orderdbDataSet;
        private orderdbDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private orderdbDataSetTableAdapters.orderitemsTableAdapter orderitemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn good_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn good_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private orderdbDataSet1 orderdbDataSet1;
        private orderdbDataSet1TableAdapters.ordersTableAdapter ordersTableAdapter1;
    }
}

