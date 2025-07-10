using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fiveConstructorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //constructor overloading
            Person p1 = new Person();
            p1.ShowInfo();

            Console.WriteLine();

            // Object using constructor 2 (1 argument)
            Person p2 = new Person("Ali");
            p2.ShowInfo();

            Console.WriteLine();

            // Object using constructor 3 (2 arguments)
            Person p3 = new Person("Sara", 25);
            p3.ShowInfo();
        }
    }
}
