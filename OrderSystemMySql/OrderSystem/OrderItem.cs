using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderSystem
{
    public class OrderItem
    {
        [Key, Column(Order = 1)]
        public int OrderItemId { get; set; }
        public Good good { get; set; }
        public int Number { get; set; }
        public string goodName => good.Name;
        public double goodPrice => good.Price;
        public double TotalSum
        {
            get=> goodPrice * Number;
            set => TotalSum=value;

            }

        public Order Order { get; set; }


        public OrderItem(String name, double price, int number)
        {
            good = new Good(name, price);
            Number = number;
        }

        public OrderItem()
        {
            good = new Good();
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item!=null && item.good.Equals(good);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(good.Name + "\t|");
            str.Append(good.Price +"\t|");
            str.Append(Number + "\n");
            return str.ToString();
        }
    }

    public class Good
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Good() { }

        public Good(String name, double price ){
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            Good g = obj as Good;
            return g != null && g.Name == Name && g.Price == Price;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}
