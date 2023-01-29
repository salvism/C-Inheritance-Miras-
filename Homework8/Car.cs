using System;
using System.Collections.Generic;
using System.Text;

namespace Homework8
{
    internal class Car:Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;

        public void AddFuel(double fuel = 0)
        {
            fuel += this.CurrentFuel;
            if (fuel <= this.FuelCapacity)
            {
                this.CurrentFuel = fuel;
            }
        }
    }
}
