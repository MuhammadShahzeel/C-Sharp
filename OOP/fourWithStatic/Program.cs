using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourWithStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // with static
            //creating an instance of the CarWS class
            CarWS carx = new CarWS("Toyota");
            CarWS cary = new CarWS("Honda");

            Console.WriteLine(CarWS.numberOfCars);
            CarWS.AnnounceRace();

        }
    }
}
