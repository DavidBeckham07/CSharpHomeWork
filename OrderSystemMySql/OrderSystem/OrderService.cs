using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Xml.Serialization;

namespace OrderSystem
{
    public class OrderService
    {
        public OrderContext context;
        public List<Order> orderList;
        XmlSerializer orderXmlSeri;
        string xmlFileName;


        public OrderService()
        {
            orderList = new List<Order>();
            orderXmlSeri = new XmlSerializer(typeof(List<Order>));
            context = new OrderContext();
            Order order = new Order("小红");
            order.AddItem(new OrderItem("eggs", 2.0, 2));
            order.AddItem(new OrderItem("chicken", 13.0, 2));
            context.Orders.Add(order);
            order = new Order("小明");
            order.AddItem(new OrderItem("meat", 20, 5));
            order.AddItem(new OrderItem("ball", 62, 1));

            context.Orders.Add(order);
            context.SaveChanges();



        }

        ~OrderService()
        {
            context.Dispose();
        }

        public Order SearchOrder(string field, string value)
        {
            Order order;
            switch (field.ToLower())
            {
                
                case ("id"):
                order = context.Orders.Where(x => x.OrderId == int.Parse(value)).First();
                    return order;
      
                case ("client"):
                    order = context.Orders.Where(x => x.Client == value).First();
                    return order;
                    
            }
            throw new Exception("no such order");



            /*
            IEnumerable<Order> order = orderList.AsEnumerable();
            switch (field.ToLower())
            {
                case ("id"):
                    order = order.Where(x => x.OrderId == int.Parse(value));
                    break;

                case ("client"):
                    order = order.Where(x => x.Client == value);
                    break;
            }
            if (order.ToList().Count() == 0)
            {
                throw new Exception("no such order");
            }
            return order.ToList().ElementAt(0);
            */

        }

        public void DeleteOrder(string field, string value)
        {
            Order result = SearchOrder(field, value);
            context.Orders.Remove(result);
        }

        // 初始化订单
        public Order InitOrder(string orderInitPara)
        {
            Order newOrder = new Order(orderList.Count().ToString());
            newOrder.Client = orderInitPara;
            context.Orders.Add(newOrder);
            return newOrder;

        }

        public void CompleOrder(Order order, IEnumerable<OrderItem> orderItems)
        {
            foreach (OrderItem item in orderItems)
            {
                order.AddItem(item);
            }
        }

        internal void ModiOrder(Order target, string name, string op, string num_S)
        {
            if (int.TryParse(num_S, out int num) == false)
            {
                throw new Exception("Augument illegal");
            }
            switch (op.ToLower())
            {
                case ("add"):
                    target.AddItem(name, num);
                    break;
                case ("reduce"):
                    target.AddItem(name, (-1 * num));
                    break;
            }
        }


        public void Export(string fileName)

        {
            xmlFileName = "D:\\" + fileName + ".xml";
            using (FileStream fs = new FileStream(xmlFileName, FileMode.Create))
            {
                orderXmlSeri.Serialize(fs, orderList);
            }

        }

        public void Export(string pathName, string fileName)
        {
            xmlFileName = pathName +"\\" + fileName;

            using (FileStream fs = new FileStream(xmlFileName, FileMode.Create))
            {
                orderXmlSeri.Serialize(fs, context.Orders);
            }
            
        }

        public List<Order> Import(string fileName)
        {
            if (xmlFileName.Length == 0) { throw new Exception("xml file has not yet generated"); }
            using (FileStream fs = new FileStream(xmlFileName, FileMode.Open))
            {
                var orderList = (List<Order>)orderXmlSeri.Deserialize(fs);
                foreach(var entity in context.Orders)
                {
                    context.Orders.Remove(entity);
                }

                foreach(var entity in orderList)
                {
                    context.Orders.Add(entity);
                }
            }
            return orderList;

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
            foreach (Order order in orderList)
            {
                sb.Append(order.ToString());

            }
            return sb.ToString();
        }


    }
}


