using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory electricFactory = new ElectricVehicleFactory();
            IVehicle car = electricFactory.CreateCar();
            IVehicle truck = electricFactory.CreateTruck();
            IEngine engine = electricFactory.CreateEngine();

            car.ShowDetails();
            truck.ShowDetails();
            engine.ShowDetails();

            Console.WriteLine();

            IVehicleFactory gasFactory = new GasolineVehicleFactory();
            gasFactory.CreateCar().ShowDetails();
            gasFactory.CreateTruck().ShowDetails();
            gasFactory.CreateEngine().ShowDetails();
        }
    }
}
