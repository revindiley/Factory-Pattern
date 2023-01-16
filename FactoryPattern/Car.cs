using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car : IVehicle 
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public string? Year { get; set; }
        public int? NumOfTires { get; set; }
        public string? Color { get; set; }

        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }

    }
}
