using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass04
{
    internal class ElectricCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Electric Car with an Electric Engine");
        }
    }
}
