using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ninePassObjAsArg
{

    //simple example of passing an object as an argument to a function in C#

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Ek object create kia
    //        Person p1 = new Person();
    //        p1.name = "Ali";

    //        // Function ko object pass kia
    //        ChangeName(p1);

    //        // Object ka name print kia
    //        Console.WriteLine(p1.name); // Output: Ahmed
    //    }

    //    // Function jo object ko accept karta hai aur uska name change karta hai
    //    static void ChangeName(Person person)
    //    {
    //        person.name = "Ahmed";  // Yahan object ki original property change ho rahi hai
    //    }
    //}

    //class Person
    //{
    //    public string name;
    //}




    internal class Program
    {
        static void Main(string[] args)
        {
            // Ek new Car object banaya (Constructor call hua)
            Car car1 = new Car("Mustang", "red");

            // car1 object ko Copy function mein bheja aur result car2 mein store kia
            Car car2 = Copy(car1);

            // car2 ka color aur model print kia
            Console.WriteLine(car2.color + " " + car2.model); // Output: red Mustang

            Console.ReadKey();
        }

        // Yeh function kisi bhi car object ka color change karta hai
        public static void ChangeColor(Car car, String color)
        {
            // function ke andar object ka color change kia jaa raha hai
            car.color = color;
        }

        // Yeh function ek car object ko accept karta hai aur uska copy return karta hai
        public static Car Copy(Car car)
        {
            // Ek new car object banaya gaya same model aur color ke sath
            return new Car(car.model, car.color);
        }
    }
    }
    // Car class jis mein 2 properties hain: model aur color
    class Car
    {
        public String model; // Car ka model (e.g. Mustang)
        public String color; // Car ka color (e.g. red)

        // Constructor jo jab new object banate hain to values assign karta hai
        public Car(String model, String color)
        {
            this.model = model; // this.model means current object ki model property
            this.color = color; // this.color means current object ka color
        }
    }









