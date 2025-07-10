using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeWithoutStatic
{
    internal class CarWithoutS
    {
        // ⭐ Non-static = belongs to each object.
        //    ➡️ Every object has its own copy.
        //    ➡️ Need to create objects to use.

        // ============================
        // Non-static variable
        // ============================
        // Each Car object has its own model
        public String model;
        public int numberOfCars;

        public CarWithoutS(String model)
        {
            this.model = model;
            numberOfCars++;
        }

        public void StartRace()
        {
            Console.WriteLine("The race has begun!");
        }
    }
}
