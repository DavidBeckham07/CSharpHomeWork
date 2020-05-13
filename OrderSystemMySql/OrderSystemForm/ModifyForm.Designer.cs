namespace OrderSystemForm
{
    partial class ModifyForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.itemDataGridView = new System.Windows.Forms.DataGridView();
            this.clientLabel = new System.Windows.Forms.Label();
            this.clientTextBox = new System.Windows.Forms.TextBox();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.addItemBtn = new System.Windows.Forms.Button();
            this.currentItemLabel = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.itemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.submitBtn = new System.Windows.Forms.Button();
            this.itemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).BeginInit();
            this.itemTableLayoutPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // itemDataGridView
            // 
            this.itemDataGridView.AutoGenerateColumns = false;
            this.itemDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.itemDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.itemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodNameDataGridViewTextBoxColumn,
            this.goodPriceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn,
            this.totalSumDataGridViewTextBoxColumn});
            this.itemDataGridView.DataSource = this.itemBindingSource;
            this.itemDataGridView.Location = new System.Drawing.Point(0, 178);
            this.itemDataGridView.Name = "itemDataGridView";
            this.itemDataGridView.RowHeadersWidth = 51;
            this.itemDataGridView.RowTemplate.Height = 27;
            this.itemDataGridView.Size = new System.Drawing.Size(692, 224);
            this.itemDataGridView.TabIndex = 1;
            // 
            // clientLabel
            // 
            this.clientLabel.AutoSize = true;
            this.clientLabel.Location = new System.Drawing.Point(3, 0);
            this.clientLabel.Name = "clientLabel";
            this.clientLabel.Size = new System.Drawing.Size(67, 15);
            this.clientLabel.TabIndex = 2;
            this.clientLabel.Text = "用户名：";
            // 
            // clientTextBox
            // 
            this.clientTextBox.Location = new System.Drawing.Point(232, 3);
            this.clientTextBox.Name = "clientTextBox";
            this.clientTextBox.Size = new System.Drawing.Size(100, 25);
            this.clientTextBox.TabIndex = 3;
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Location = new System.Drawing.Point(3, 60);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.itemNameTextBox.TabIndex = 4;
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(232, 60);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 25);
            this.itemPriceTextBox.TabIndex = 5;
            // 
            // addItemBtn
            // 
            this.addItemBtn.Location = new System.Drawing.Point(461, 60);
            this.addItemBtn.Name = "addItemBtn";
            this.addItemBtn.Size = new System.Drawing.Size(75, 23);
            this.addItemBtn.TabIndex = 6;
            this.addItemBtn.Text = "添加商品";
            this.addItemBtn.UseVisualStyleBackColor = true;
            this.addItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // currentItemLabel
            // 
            this.currentItemLabel.AutoSize = true;
            this.currentItemLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.itemBindingSource, "goodName", true));
            this.currentItemLabel.Location = new System.Drawing.Point(3, 119);
            this.currentItemLabel.Name = "currentItemLabel";
            this.currentItemLabel.Size = new System.Drawing.Size(0, 15);
            this.currentItemLabel.TabIndex = 7;
            this.currentItemLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(232, 122);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "增加";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Location = new System.Drawing.Point(461, 122);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(72, 22);
            this.minusBtn.TabIndex = 9;
            this.minusBtn.Text = "减少";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // itemTableLayoutPanel
            // 
            this.itemTableLayoutPanel.ColumnCount = 3;
            this.itemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.itemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.itemTableLayoutPanel.Controls.Add(this.currentItemLabel, 0, 2);
            this.itemTableLayoutPanel.Controls.Add(this.addBtn, 1, 2);
            this.itemTableLayoutPanel.Controls.Add(this.minusBtn, 2, 2);
            this.itemTableLayoutPanel.Controls.Add(this.clientTextBox, 1, 0);
            this.itemTableLayoutPanel.Controls.Add(this.itemNameTextBox, 0, 1);
            this.itemTableLayoutPanel.Controls.Add(this.itemPriceTextBox, 1, 1);
            this.itemTableLayoutPanel.Controls.Add(this.addItemBtn, 2, 1);
            this.itemTableLayoutPanel.Controls.Add(this.clientLabel, 0, 0);
            this.itemTableLayoutPanel.Controls.Add(this.submitBtn, 2, 0);
            this.itemTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.itemTableLayoutPanel.Name = "itemTableLayoutPanel";
            this.itemTableLayoutPanel.RowCount = 3;
            this.itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.91667F));
            this.itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.08333F));
            this.itemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.itemTableLayoutPanel.Size = new System.Drawing.Size(551, 169);
            this.itemTableLayoutPanel.TabIndex = 10;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Controls.Add(this.itemTableLayoutPanel);
            this.mainPanel.Controls.Add(this.itemDataGridView);
            this.mainPanel.Location = new System.Drawing.Point(12, 36);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(750, 402);
            this.mainPanel.TabIndex = 11;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(461, 3);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "提交";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // itemBindingSource
            // 
            this.itemBindingSource.DataSource = typeof(OrderSystem.OrderItem);
            // 
            // goodNameDataGridViewTextBoxColumn
            // 
            this.goodNameDataGridViewTextBoxColumn.DataPropertyName = "goodName";
            this.goodNameDataGridViewTextBoxColumn.HeaderText = "goodName";
            this.goodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodNameDataGridViewTextBoxColumn.Name = "goodNameDataGridViewTextBoxColumn";
            this.goodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // goodPriceDataGridViewTextBoxColumn
            // 
            this.goodPriceDataGridViewTextBoxColumn.DataPropertyName = "goodPrice";
            this.goodPriceDataGridViewTextBoxColumn.HeaderText = "goodPrice";
            this.goodPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goodPriceDataGridViewTextBoxColumn.Name = "goodPriceDataGridViewTextBoxColumn";
            this.goodPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.goodPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalSumDataGridViewTextBoxColumn
            // 
            this.totalSumDataGridViewTextBoxColumn.DataPropertyName = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.HeaderText = "TotalSum";
            this.totalSumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalSumDataGridViewTextBoxColumn.Name = "totalSumDataGridViewTextBoxColumn";
            this.totalSumDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalSumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "ModifyForm";
            this.Text = "ModifyForm";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemDataGridView)).EndInit();
            this.itemTableLayoutPanel.ResumeLayout(false);
            this.itemTableLayoutPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView itemDataGridView;
        private System.Windows.Forms.Label clientLabel;
        private System.Windows.Forms.TextBox clientTextBox;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Button addItemBtn;
        private System.Windows.Forms.Label currentItemLabel;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.BindingSource itemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSumDataGridViewTextBoxColumn;
        private System.Windows.Forms.TableLayoutPanel itemTableLayoutPanel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Panel mainPanel;
    }
}