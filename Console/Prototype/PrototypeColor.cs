using System;
using System.Collections.Generic;
using System.Text;

namespace Console.Prototype
{
    public class PrototypeColor
    {

        public PrototypeColor()
        {
            VehicleColor = new VehicleColor();
        }
        VehicleColor VehicleColor;
        public VehicleColor SetColor(string colorName)
        {
            VehicleColor.Color = colorName;
            return VehicleColor;
        }
        public PrototypeColor from(VehicleColor objectFrom)
        {
            VehicleColor = new VehicleColor
            {
                Color = objectFrom.Color
            };
            return this;
        }
        public VehicleColor Copy()
        {
            
            return VehicleColor;
        }

    }
}
