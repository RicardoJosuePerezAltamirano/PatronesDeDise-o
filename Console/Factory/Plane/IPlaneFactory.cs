using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Factory.Plane
{
    public interface IPlaneFactory
    {
        Plane BuildOrCreate();
        IPlaneFactory SetWings(string parameter);
        IPlaneFactory SetUndercarriage(string parameter);
        IPlaneFactory SetFuselage(string parameter);
    }
}
