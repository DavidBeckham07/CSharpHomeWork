using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderSystem
{

    public class Order
    {
        public List<OrderItem> Items { get; set; }
        [Key, Column(Order =1)]
        public int OrderId { get; set; }
        public String Client { get; set; }
        //public double TotalSum { get; set; }
        public double TotalSum {
            get => (Items.ConvertAll(x => x.TotalSum).Sum());
            set => TotalSum = value;
        } 

        //无参数构造函数
        public Order()
        {
            Items = new List<OrderItem>();
        }

        public Order(string name)
        {
            Client = name;
            Items = new List<OrderItem>();
        }

        public override bool Equals(object obj)
        {
            if (obj is Order order)
            {
                foreach (OrderItem item0 in order.Items)
                {
                    if (this.Items.IndexOf(item0) < 0)
                    {
                        return false;
                    }
                }
                return OrderId == order.OrderId && Client == order.Client && Items.Count == order.Items.Count;
            }
            else
            {
                throw (new Exception("error: uncomparable"));
            }
        }

        public void AddItem(OrderItem item)
        {
            IEnumerable<OrderItem> items = Items.AsEnumerable().Where(x => x.Equals(item));
            if (items.Count() == 0)
            {
                Items.Add(item);
            }
            else
            {
                items.ToList()[0].Number += item.Number;
            }

        }

        /*
                public void AddItem(String info)
                {
                        OrderItem item = new OrderItem(info);
                        Items.Add(item);
                }
                */
        /*
        public bool Equals(Object obj)
        {
            Order order = obj as Order;
            foreach (OrderItem item in order.Items) {
                if (!this.Items.Contains(item))
                {
                    return false;
                }
            }
            return order != null && order.Client == Client && order.ID == ID && order.Items.Count == Items.Count;
        }
        */

        public override string ToString()
        {

            StringBuilder str = new StringBuilder();

            str.Append("\n-----------------------\n");
            str.Append("ID:" + OrderId + "\n");
            str.Append("Client:" + Client + "\n");
            str.Append("-----------------------\n");
            str.Append("Item\t|Price\t|Number\n");
            str.Append("-----------------------\n");
            foreach (OrderItem item in Items)
            {
                str.Append(item);
                str.Append("-----------------------\n");
            }
            return str.ToString();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void AddItem(string name, int num)

        {
            IEnumerable<OrderItem> item = Items.AsEnumerable().Where(x => x.good.Name == name);
            if (item.ToList().Count() == 0)
            {
                throw new Exception("no such item found!");

            }
            OrderItem target = item.ToList()[0];

            target.Number += num;
            if (target.Number == 0)
            {
                Items.Remove(target);
            }
            else if (target.Number < 0)
            {
                target.Number += num;
                throw new Exception("the number of remnant could not be negtive");
            }

        }


    }
}
