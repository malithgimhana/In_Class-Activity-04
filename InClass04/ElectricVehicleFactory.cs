using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass04
{
    internal class ElectricVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new ElectricCar();
        }
        public IEngine CreateEngine()
        {
            return new ElectricEngine();
        }
        public IVehicle CreateTruck()
        {
            return new ElectricTruck();
        }

    }
}
