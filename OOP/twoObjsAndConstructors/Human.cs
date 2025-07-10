using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoObjsAndConstructors
{
    internal class Human
    {

        public string name;
        public int age;

        //note: constructor is a special method that is called when an object is created
        //constructor name must match class name
        //and it does not have a return type, not even void
        //must be public to be accessible outside the class
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating.");
        }

        public void Sleep()
        {
            Console.WriteLine(name + " is sleeping.");
        }
    }
}
