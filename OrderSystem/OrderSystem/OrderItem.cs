﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OrderSystem
{
    public class OrderItem
    {
        public Goods goods;
        public int Number { get; set; }
        public double TotalSum => goods.Price * Number;


        public OrderItem(String name, double price, int number)
        {
            goods = new Goods(name, price);
            Number = number;
        }

        public OrderItem()
        {
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(goods, Number, TotalSum);
        }

        public override bool Equals(object obj)
        {
            OrderItem item = obj as OrderItem;
            return item!=null && item.goods.Equals(goods);
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(goods.Name + "\t|");
            str.Append(goods.Price +"\t|");
            str.Append(Number + "\n");
            return str.ToString();
        }
    }

    public class Goods
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Goods() { }

        public Goods(String name, double price ){
            Name = name;
            Price = price;
        }

        public override bool Equals(object obj)
        {
            Goods g = obj as Goods;
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
