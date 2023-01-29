using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    internal class Notebook:Product
    {
        public Notebook(string name, double price) : base(name, price)
        {

        }
        public int RAM;
        public int Storage;
    }
}
