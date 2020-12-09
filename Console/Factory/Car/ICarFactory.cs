using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Factory
{
    public interface ICarFactory
    {
        Car Create();
        ICarFactory SetName(string name);
        ICarFactory SetMark(string mark);
        ICarFactory SetControl();
        
    }
}
