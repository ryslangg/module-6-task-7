using System;
using System.Collections.Generic;
using System.Text;

namespace Module_6_Task_7.Entities
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string GetInfo()
        {
            return $"{Name} (${Price})";
        }
    }
}
