using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    internal class Phone:Product
    {
        public Phone(string name, double price) : base(name, price)
        {

        }
        public int Camera;
    }
}
