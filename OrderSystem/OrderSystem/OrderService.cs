using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OrderSystem
{
    class OrderService
    {
        LinkedList<Order> orderList;


        public OrderService()
        {
            orderList = new LinkedList<Order>();
        }

        public Order SearchOrder(String field, string value)
        {
            IEnumerable<Order> order = orderList.AsEnumerable();
            switch(field){
                case ("id"):
                    order = order.Where(x => x.ID == value);
                    break;
                case ("client"):
                    order = order.Where(x => x.Client == value);
                    break;
            }
            if(order.ToList().Count() == 0)
            {
                throw new Exception("no such order");
            }
            return order.ToList().ElementAt(0);

        }

        internal void DeleteOrder(string field, string value)
        {
            Order result = SearchOrder(field, value);
            orderList.Remove(result);
        }

        // 初始化订单
        internal void InitOrder(string orderInitPara)
        {
            Order newOrder = new Order(orderList.Count().ToString());
            newOrder.Client = orderInitPara;
            orderList.AddLast(newOrder);

        }

        internal void CompleOrder(IEnumerable<string> orderItemPara)
        {
            foreach(string info in orderItemPara)
            {
                string[] paras = info.Split(" ");
                Order order = orderList.ElementAt(orderList.Count - 1);
                string name = "";
                for(int i = 0; i <= paras.Count() - 3; i++)
                {
                    name += paras[i];
                }

                OrderItem item = new OrderItem(name, double.Parse(paras[paras.Count() - 2]), int.Parse(paras[paras.Count() - 1]));
                order.AddItem(item);
            }
        }

        internal void ModiOrder(Order target, string name, string op, string num)
        {
            switch (op.ToLower())
            {
                case ("add"):
                    target.AddItem(name, num);
                    break;
                case ("reduce"):
                    target.AddItem(name, (-1 * int.Parse(num)).ToString());
                    break;
            }
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Order order in orderList)
            {
                sb.Append(order.ToString());

            }
            return sb.ToString();
        }
    }


    class Order
    {
        private List<OrderItem> Items;
        public String ID { get; set; }
        public String Client { get; set; }
        public double TotalSum => Items.ConvertAll(x => x.TotalSum).Sum();

        //无参数构造函数，分配id号
        public Order(string id)
        {
            ID = id;
            Items = new List<OrderItem>();
        }

        public override bool Equals(object obj)
        {
            if (obj is Order order)
            {
                return ID == order.ID;
            }
            else
            {
                throw (new Exception("error: uncomparable"));
            }
        }

        public void AddItem(OrderItem item)
        {
            IEnumerable<OrderItem> items = Items.AsEnumerable().Where(x => x.Equals(item));
            if(items.Count() == 0)
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

        public override string ToString()
        {

            StringBuilder str = new StringBuilder();

            str.Append("\n-----------------------\n");
            str.Append("ID:" + ID + "\n");
            str.Append("Client:" + Client + "\n");
            str.Append("-----------------------\n");
            str.Append("Item\t|Price\t|Number\n" );
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
            return HashCode.Combine(Items, ID, Client, TotalSum);
        }

        internal void AddItem(string name, string num)

        {
            IEnumerable<OrderItem> item = Items.AsEnumerable().Where(x => x.goods.Name == name);
            if(item.ToList().Count() == 0)
            {
                throw new Exception("no such item found!");
            }
            item.ToList()[0].Number += int.Parse(num);
        }
    }
}
