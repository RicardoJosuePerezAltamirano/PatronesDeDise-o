
using Console.AbstractFactory;
using Console.Factory;
using Console.Factory.Plane;
using Console.Prototype;
using System;
using static Console.Helpers;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var car1 = FactoryCar(TypeCar.latino);
            //var car2 = FactoryCar(TypeCar.ingles);
            //System.Console.WriteLine($"el control del coche 1 es: {car1.Control}");
            //System.Console.WriteLine($"el control del coche 2 es: {car2.Control}");
            CreateCarAndPlane();
            System.Console.ReadLine();
        }
        static Car FactoryCar(TypeCar typeCar)
        {
            switch(typeCar)
            {
                case TypeCar.ingles:
                    return new CarRightFactory().SetControl().SetMark("BMW").SetName("M4").Create();
                    break;
                case TypeCar.latino:
                    return new CarLeftFactory().SetControl().SetMark("Ford").SetName("focus").Create();
                    break;
            }
            return default(Car);
        }
        // abstractFactory para prototype
        static void CreateCarAndPlane()
        {
            IVehicleAbstractFactory vehicleAbstractFactory = new VehicleAbstractFactory();
            var Car = vehicleAbstractFactory
                .CarFactory(TypeCar.latino)
                .SetControl()
                .SetMark("BMW")
                .SetName("M4")
                .Create();
            var prototypeColor = new PrototypeColor();
            Car.Color = prototypeColor.SetColor("Blue");
            var colornewCar = prototypeColor.from(Car.Color).SetColor("Red");
            var Car2 = vehicleAbstractFactory
                .CarFactory(TypeCar.latino)
                .SetControl()
                .SetMark("Ford")
                .SetName("Fiesta")
                .Create();
            var Car3 = vehicleAbstractFactory
                .CarFactory(TypeCar.latino)
                .SetControl()
                .SetMark("chevrolet")
                .SetName("silverado")
                .Create();
            Car3.Color = prototypeColor.from(Car.Color).Copy();
            Car2.Color = colornewCar;
            System.Console.WriteLine($"el color del coche 1 {Car.Name} es {Car.Color.Color}");
            System.Console.WriteLine($"el color del coche 2 {Car2.Name} es {Car2.Color.Color}");
            System.Console.WriteLine($"el color del coche 3 {Car3.Name} es {Car3.Color.Color} copiado de protoripo del coche 1");
        }
        
        
    }
}
