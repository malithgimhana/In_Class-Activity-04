using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass04
{
    internal class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar()
        {
            return new GasolineCar();
        }
        public IEngine CreateEngine()
        {
            return new GasolineEngine();
        }
        public IVehicle CreateTruck()
        {
            return new GasolineTruck();
        }
    }
}
