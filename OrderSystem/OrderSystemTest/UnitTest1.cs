using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderSystem;
using System.Collections.Generic;

namespace OrderSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        OrderService service;

        [TestInitialize]
        public void TestInitial()
        {
            service = new OrderService();
            Order order1 = new Order();
            order1.Client = "user";
            service.orderList.Add(order1);
            List<OrderItem> orderItem1 = new List<OrderItem>();
            orderItem1.Add(new OrderItem("item1", 1, 1));
            orderItem1.Add(new OrderItem("item2", 2, 2));
            order1.Items = (List<OrderItem>)orderItem1;
            foreach (OrderItem item in orderItem1) { order1.AddItem(item); }


        }

  

        [TestMethod]
        public void TestMethod1()
        {
           


            Order result = new Order();
            result.Client = "user";
            List<OrderItem> orderItem = new List<OrderItem>();
            orderItem.Add(new OrderItem("item1", 1, 1));
            orderItem.Add(new OrderItem("item2", 2, 2));

            result.Items = (List<OrderItem>)orderItem;
            foreach (OrderItem item in orderItem) { result.AddItem(item); }

            Order order = service.SearchOrder("client", "user");

            Assert.IsNotNull(order);
            Assert.AreEqual(order, result);
        }
        
        [TestMethod]
        public void TestMethod3()
        {
            // OrderService service = new OrderService();
            service.DeleteOrder("client", "user");

            Assert.IsNotNull(service);
            Assert.IsTrue(service.orderList.Count == 0);
        }



    }
}
