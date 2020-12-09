using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Factory
{
    public class CarRightFactory : ICarFactory
    {
        Car Car;
        public CarRightFactory()
        {
            Car = new Car();
        }
        public Car Create()
        {
            return Car;
        }

        public ICarFactory SetControl()
        {
            Car.Control = "Right";
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
