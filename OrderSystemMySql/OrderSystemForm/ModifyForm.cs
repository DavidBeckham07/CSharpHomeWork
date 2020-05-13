using System;
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
    public partial class ModifyForm : Form
    {

        public Order Current { get; set; }
        public List<OrderItem> ItemList => Current.Items;
        public string ItemName { set; get; }
        public double ItemPrice { set; get; }
        public OrderService Service;
        Boolean isCreateForm { set; get; }

        public void update(){
            this.itemBindingSource.ResetBindings(true);
            this.itemBindingSource.DataSource = Current.Items;
        }


        public ModifyForm(OrderService service, Order current)
        {
            InitializeComponent();
            this.Current = current;
            this.Service = service;


            this.clientTextBox.DataBindings.Add("Text", this.Current, "Client");
            this.itemNameTextBox.DataBindings.Add("Text", this, "ItemName");
            this.itemPriceTextBox.DataBindings.Add("Text", this, "ItemPrice");

            this.itemBindingSource.DataSource = current.Items;
            this.itemBindingSource.ResetBindings(false);

            if (Current.Client == null)
            {
                isCreateForm = true;
            }
            else
            {
                isCreateForm = false;
            }



        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            OrderItem item = new OrderItem(ItemName, ItemPrice, 1);
            Current.AddItem(item);
            update();


            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(currentItemLabel.Text.Length > 0)
            {
                Current.AddItem(currentItemLabel.Text, 1);
            }
            update();

        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (currentItemLabel.Text.Length > 0)
            {
                Current.AddItem(currentItemLabel.Text, -1);
            }
            update();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (isCreateForm)
            {
                if(clientTextBox.TextLength == 0)
                {
                    MessageBox.Show("用户名为空", "提示");
                }
                else
                {
                    Service.orderList.Add(Current);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
