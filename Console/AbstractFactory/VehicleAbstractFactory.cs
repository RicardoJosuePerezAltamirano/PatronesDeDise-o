using Console.Factory;
using Console.Factory.Plane;
using System;
using System.Collections.Generic;
using System.Text;

namespace Console.AbstractFactory
{
    public class VehicleAbstractFactory : IVehicleAbstractFactory
    {
        public ICarFactory CarFactory(Helpers.TypeCar typeCar)
        {
            switch (typeCar)
            {
                case Helpers.TypeCar.ingles:
                    return new CarRightFactory();
                    break;
                case Helpers.TypeCar.latino:
                    return new CarLeftFactory();
                    break;
            }
            return default(ICarFactory);
        }

        public IPlaneFactory PlaneFactory()
        {
            return new PlaneFactory();
        }
    }
}
