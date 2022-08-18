using System;
using System.Collections.Generic;

namespace BasicClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "McClarren";
            myCar.Model = "F1";
            myCar.Year = 2022;

            var ferarri = new Car()
            {
                Make = "Ferarri",
                Model = "Spider",
                Year = 1999
            };

            var jeep = new Car("Jeep", "Wrangler", 2012);
            var carList = new List<Car>() { myCar, ferarri, jeep }; 
            

            foreach ( var vechicle in carList)
            {
                Console.WriteLine($"{vechicle.Make} {vechicle.Model} {vechicle.Year}");
            }
        }
    }
}
