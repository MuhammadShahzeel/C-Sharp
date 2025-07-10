using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace twoObjsAndConstructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
            //creating an instance of the Human class
            //instead of this use constructors
            //Human human1 = new Human();
            //Human human2 = new Human();

            //human1.name = "Rick";
            //human1.age = 65;

            //human2.name = "Morty";
            //human2.age = 16;

            //note: constructor is a special method that is called when an object is created
            Human human1 = new Human("Rick", 65);
            Human human2 = new Human("Morty", 16);

            human1.Eat();
            human1.Sleep();

            human2.Eat();
            human2.Sleep();

        }
    }
}
