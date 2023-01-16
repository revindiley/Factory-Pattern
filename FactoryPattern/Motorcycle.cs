using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : IVehicle
    {
        public string Color { get; set; }
        public bool HasHandbreak { get; set; }


        public void Drive()
        {
            Console.WriteLine("Building a new motorcycle!");

        }
    }
}
