using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeWithoutStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // without static
            //creating an instance of the CarWithoutS class
            CarWithoutS car1 = new CarWithoutS("Toyota");
            CarWithoutS car2 = new CarWithoutS("Honda");
            //accessing the model of the car
            Console.WriteLine("Car 1 model: " + car1.model);
            Console.WriteLine("Car 2 model: " + car2.model);
            //accessing the number of cars created
            Console.WriteLine("Number of cars created: " + car1.numberOfCars);
            Console.WriteLine("Number of cars created: " + car2.numberOfCars);

            //calling the StartRace method
            car1.StartRace();
        }
    }
}
