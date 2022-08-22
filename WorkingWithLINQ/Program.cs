using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
// https://github.com/marisawadsworth/CSharp-Fundamentals-by-Bob-Tabor/blob/master/18_Working_with_LINQ/Program.cs

namespace WorkingWithLINQ
{
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ query syntax
            /*
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;

            foreach (var car in bmws)
            {
                Console.WriteLine($"{car.Model}, {car.VIN}");
            }
            */
            /*
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            foreach (var car in orderedCars)
            {
                Console.WriteLine($"{car.Year}, {car.Model}, {car.VIN}");
            }
            */

            // LINQ method syntax
            // below fat arrow => is a lambda expression
            /*
            var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            foreach (var car in bmws)
            {
                Console.WriteLine($"{car.Model}, {car.VIN}");
            }
            */
            /*
            var orderCars = myCars.OrderByDescending(p => p.Year);
            foreach (var car in orderCars)
            {
                Console.WriteLine($"{car.Year}, {car.Model}, {car.VIN}");
            }
            */

            //var firstBMW = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "BMW");
            //Console.WriteLine(firstBMW.VIN);

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            Console.ReadLine(); 
        }
    }
}
