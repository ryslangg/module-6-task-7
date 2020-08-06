using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Module_6_Task_7.Entities
{
    public class Cart
    {
        private List<Product> _products = new List<Product>();
        private Random rand = new Random();

        public void AddProduct(Product product) 
        {
            _products.Add(product);
        }

        public double Sum()
        {
            return _products.Sum(product => product.Price);
        }

        public void RemoveProduct(int index)
        {
            _products.RemoveAt(index);
        }

        public int Count()
        {
            return _products.Count();
        }

        public Product DropRandomProduct()
        {
            int index = rand.Next(0,Count());
            Product product = _products[index];
            RemoveProduct(index);
            return product;
        }

        public void PrintAllProducts()
        {
            foreach(Product product in _products)
            {
                Console.WriteLine($"{product.Name} - {product.Price}$");
            }
        }
    }
}
