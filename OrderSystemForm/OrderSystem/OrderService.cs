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
        public List<Order> orderList;
        XmlSerializer orderXmlSeri;
        string xmlFileName;


        public OrderService()
        {
            orderList = new List<Order>();
            orderXmlSeri = new XmlSerializer(typeof(List<Order>));
        }

        public Order SearchOrder(string field, string value)
        {
            IEnumerable<Order> order = orderList.AsEnumerable();
            switch (field.ToLower())
            {
                case ("id"):
                    order = order.Where(x => x.ID == value);
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

        }

        public void DeleteOrder(string field, string value)
        {
            Order result = SearchOrder(field, value);
            orderList.Remove(result);
        }

        // 初始化订单
        public Order InitOrder(string orderInitPara)
        {
            Order newOrder = new Order(orderList.Count().ToString());
            newOrder.Client = orderInitPara;
            orderList.Add(newOrder);
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
                orderXmlSeri.Serialize(fs, orderList);
            }
            
        }

        public List<Order> Import()
        {
            if (xmlFileName.Length == 0) { throw new Exception("xml file has not yet generated"); }
            using (FileStream fs = new FileStream(xmlFileName, FileMode.Open))
            {
                List<Order> orderList = (List<Order>)orderXmlSeri.Deserialize(fs);
            }
            return orderList;

        }

        public void Import(string fileName)
        {
            if (fileName.Length == 0) { throw new Exception("xml file has not yet generated"); }
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                List<Order> orderList = (List<Order>)orderXmlSeri.Deserialize(fs);
                this.orderList = orderList;
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
            foreach (Order order in orderList)
            {
                sb.Append(order.ToString());

            }
            return sb.ToString();
        }


    }
}


