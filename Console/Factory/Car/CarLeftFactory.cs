using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Factory
{
    public class CarLeftFactory : ICarFactory
    {
        Car Car;
        public CarLeftFactory()
        {
            Car = new Car();
        }
        public Car Create()
        {
            return Car;
        }

        public ICarFactory SetControl()
        {
            Car.Control = "left";
            return this;
        }

        public ICarFactory SetMark(string mark)
        {
            Car.Mark = mark;
            return this;
        }

        public ICarFactory SetName(string name)
        {
            Car.Name = name;
            return this;
        }
    }
}
