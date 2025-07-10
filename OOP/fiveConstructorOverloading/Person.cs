using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiveConstructorOverloading
{
    internal class Person
    {
        public string name;
        public int age;

        // Constructor 1: No parameters
        public Person()
        {
            name = "Unknown";
            age = 0;
        }

        // Constructor 2: One parameter
        public Person(string name)
        {
            this.name = name;
            age = 0;
        }

        // Constructor 3: Two parameters
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }
}
