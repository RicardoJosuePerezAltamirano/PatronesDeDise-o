using Console.Factory;
using Console.Factory.Plane;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.AbstractFactory
{
    public interface IVehicleAbstractFactory
    {
        ICarFactory CarFactory(Helpers.TypeCar typeCar);
        IPlaneFactory PlaneFactory();
    }
}
