using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle CreateVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car/truck":
                case "4":
                    return new Car();
                case "Motorcycle":
                case "2":
                case "bike":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }

      
    }
}
