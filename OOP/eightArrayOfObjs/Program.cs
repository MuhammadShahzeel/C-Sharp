using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eightArrayOfObjs
{
    internal class Program
    {
        static void Main(string[] args)

        //you can use the following code to create an array of objects in C#.
        //This code creates an array of Car objects, initializes them with different models, and then prints the model of each car.
        {
            Car[] garage = { new Car("Mustang"), new Car("Corvette"), new Car("Lambo") };

            foreach (Car car in garage)
            {
                Console.WriteLine(car.model);
            }
        }
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}

