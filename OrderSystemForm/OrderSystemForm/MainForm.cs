﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderSystem;

namespace OrderSystemForm
{
    public partial class MainForm : Form
    {
        OrderService service;
        List<Order> queryOrder;
        Form modifyForm;
        public string Field { set; get; }
        public string Value { set; get; }

        public MainForm()
        {
            
            InitializeComponent();

            fieldComboBox.DataBindings.Add("SelectedItem", this, "Field");
            valueTextBox.DataBindings.Add("Text", this, "Value");

            adjustWidth();

            service = new OrderService();
            queryOrder = new List<Order>();

            Order order = new Order();
            order.Client = "client1";
            order.AddItem(new OrderItem("eggs", 1.0, 5));
            order.AddItem(new OrderItem("chicken", 2.0, 6));
            service.orderList.Add(order);
            order = new Order();
            order.Client = "client2";
            order.AddItem(new OrderItem("eggs", 1.0, 7));
            order.AddItem(new OrderItem("order", 5, 8));
            service.orderList.Add(order);
            this.orderBindingSource.DataSource = service.orderList;
            this.orderBindingSource.ResetBindings(true);


        }

        public void adjustWidth()
        {
            int cellWidth = this.buttomTableLayoutPanel.Width / 12;
            this.orderDataGridView.RowHeadersWidth = cellWidth;
            this.itemDataGridView.RowHeadersWidth = cellWidth;
            for (int i = 0; i < orderDataGridView.Columns.Count; i++)
            {
                this.orderDataGridView.Columns[i].Width = cellWidth;
            }

            for (int i = 0; i < itemDataGridView.Columns.Count; i++)
            {
                this.itemDataGridView.Columns[i].Width = cellWidth;
            }

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            modifyForm = new ModifyForm(service, order);
            modifyForm.ShowDialog();
            this.orderBindingSource.ResetBindings(true);
            this.orderBindingSource.DataSource = service.orderList;
        }

        private void SearchOrderBtn_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.ResetBindings(false);
            queryOrder.Clear();
            try
            {
                Order o = service.SearchOrder(Field, Value);
                queryOrder.Add(o);
            }
            catch
            {
            }
            this.orderBindingSource.ResetBindings(true);
            this.orderBindingSource.DataSource = queryOrder;
        }

        private void KeysComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.keysComboBox.Text = (string)this.keysComboBox.SelectedItem;
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            adjustWidth();
        }



        private void ModifyOrderBtn_Click(object sender, EventArgs e)
        {
            Order current = (Order)this.orderBindingSource.Current;
            new ModifyForm(service, current).ShowDialog();
            this.orderBindingSource.ResetBindings(true);
            this.orderBindingSource.DataSource = service.orderList;



        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            this.orderBindingSource.DataSource = service.orderList;
            this.orderBindingSource.ResetBindings(true);
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            if(xmlOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = xmlOpenFileDialog.FileName;
                service.Import(fileName);
                this.orderBindingSource.DataSource = service.orderList;
                this.orderBindingSource.ResetBindings(true);
            }

        }

        private void ExportBtn_Click(object sender, EventArgs e)
        {
            xmlSaveFileDialog.Filter = "xml文件(*.xml)|*.xml";
            xmlSaveFileDialog.DefaultExt = "D:\\";
          
            if(xmlSaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = xmlSaveFileDialog.FileName.ToString();
                string pathName = path.Substring(0, path.LastIndexOf("\\"));
                string file = path.Substring(path.LastIndexOf("\\")+1);
                service.Export(pathName, file);
                
            }
            
            

        }

        private void ButtomTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
