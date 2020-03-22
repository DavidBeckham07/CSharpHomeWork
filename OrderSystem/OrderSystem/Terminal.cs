using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{


    class Terminal
    {
        OrderService service;
        OrderIO io;

        public Terminal()
        {
            service = new OrderService();
            io = new OrderIO();
        }

        public void Run()
        {
                while (true)
                {
                    string op = io.GetString("input add (an order)/ search (order)/ delete (order) / modify (order) / show (current orderlist)to start the service.");
                    try
                    {
                        switch (op.ToLower())
                        {
                            case ("add"):
                                CreateOrder();
                                io.Printf("add successfully");
                                break;

                            case ("search"):
                                Order result = SearchOrder();
                                io.Printf(result);
                                break;

                            case ("delete"):
                                DeleteOrder();
                            io.Printf("delete successfully, now the order list is\n" + service);
                                break;

                        case ("modify"):
                            ModifyOrder();
                            io.Printf("modify successfully, now the order list is\n " + service);
                            break;
                        case ("show"):
                            io.Printf(service);
                            break;


                            default:
                                throw new Exception("illegal input");
                        }
                    }
                    catch(Exception e)
                    {
                        io.Printf(e.Message);
                    }

                }

           
        }

        private void ModifyOrder()
        {
            Order target = SearchOrder();
            io.Printf(target);
            do
            {
                string[] paras = io.GetModiPara();
                service.ModiOrder(target, paras[0], paras[1], paras[2]);
            }
            while (io.checkContinue());
        }

        private void DeleteOrder()
        {
            string[] deletePara = io.GetDeletePara();
            service.DeleteOrder(deletePara[0], deletePara[1]);
        }

        private Order SearchOrder()
        {
            string[] searchPara = io.GetSearchPara();
            Order result = service.SearchOrder(searchPara[0], searchPara[1]);
            return result;
        }

        private void CreateOrder()
        {
            String orderInitPara = io.GetString("input the client's name please");

            IEnumerable<String> orderItemPara;

                service.InitOrder(orderInitPara);
            if(io.checkContinue("do you want to add some items?(yes / no)"))
            {
                do
                {
                    try
                    {
                        orderItemPara = io.GetItemsPara();
                        service.CompleOrder(orderItemPara);
                    }
                    catch (Exception e)
                    {
                        io.Printf(e.Message);
                    }

                }
                while (io.checkContinue("continue to add items?(yes / no)"));
            }
                

        }
    }
}
