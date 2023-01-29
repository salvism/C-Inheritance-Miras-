using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    internal class Product
    {
        public Product(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name;
        public double Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}");
        }
    }
}
