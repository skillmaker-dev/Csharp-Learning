using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var cars = Cars.GetCars();
            var _where = cars.Where(n => n.Price < 50d);
            //Where
            foreach (var car in _where)
            {
                Console.WriteLine(car.Name + " Price: " + car.Price);
            }
            //Single (Use SingleOrDefault because it is safer)
            var _single = cars.Single(n => n.Name == "Mazda");
            Console.WriteLine("Name: " + _single.Name + " Price: " + _single.Price);
            //First - FirstOrDefault
            var _first = cars.FirstOrDefault(n => n.Price >= 40);
            Console.WriteLine("First car that is higher then 40 is: " + _first.Name);
            //Last - LastOrDefault
            var _last = cars.LastOrDefault(n => n.Price >= 40);
            Console.WriteLine("Last car that is higher then 40 is: " + _last.Name);
            //Min
            var _min = cars.Min(n => n.Price);
            Console.WriteLine("Car with minimum price is: " + _min);
            //Max
            var _max = cars.Max(n => n.Price);
            Console.WriteLine("Car with maximum price is: " + _max);
            //Count 
            var _count = cars.Count();
            Console.WriteLine("Nulber of cars is: " + _count);
            //Sum
            var _sum = cars.Sum(n => n.Price);
            Console.WriteLine("Total price of all cars is: " + _sum);
            //Average 
            var _average = cars.Average(n => n.Price);
            Console.WriteLine("Average price of cars is: " + _average);
            //OrderBy - OrderByDescending
            var _orderBy = cars.OrderBy(n => n.Name);
            Console.WriteLine("Cars ordered by Name:");
            foreach (var car in _orderBy)
            {
                Console.WriteLine(car.Name + " Price: " + car.Price);
            }



            //Get the most expensive car
            var maxCar = cars.Single(n => n.Price == cars.Max(b => b.Price));
            Console.WriteLine("The most expensive car is: " + maxCar.Name);


        }
    }
}
