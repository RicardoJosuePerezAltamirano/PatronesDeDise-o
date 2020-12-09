using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Factory.Plane
{
    public class PlaneFactory : IPlaneFactory
    {
        Plane Plane;
        public PlaneFactory()
        {
            Plane = new Plane();
        }
        public Plane BuildOrCreate()
        {
            return Plane;
        }
        public IPlaneFactory SetFuselage(string parameter)
        {
            // validations
            Plane.Fuselage = parameter;
            return this;
        }
        public IPlaneFactory SetUndercarriage(string parameter)
        {
            Plane.Undercarriage = parameter;
            return this;
        }
        public IPlaneFactory SetWings(string parameter)
        {
            Plane.Wings = parameter;
            return this;
        }
    }
}
