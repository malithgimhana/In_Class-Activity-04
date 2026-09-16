using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass04
{
    public class GasolineCar: IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Gasoline Car with a Gasoline Engine");
        }
    }
}
