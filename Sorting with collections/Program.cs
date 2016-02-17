using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_with_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car("CC 12 123", "Volvo V40", 2002));
            cars.Add(new Car("AA 12 123", "BMW I320", 1998));
            cars.Add(new Car("DD 12 123", "Audi A6 TSI", 2008));
            cars.Add(new Car("BB 12 123", "Mercedes E320", 2006));
            cars.Add(new Car("EE 12 123", "Volvo V40", 2001));

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            // Do a standard sort (on registration number)
            cars.Sort();

            Console.WriteLine("\n===============\n");

            Console.WriteLine("Sort by registration number");

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            // Sort by year
            cars.Sort(new CarYearComparator());

            Console.WriteLine("\n===============\n");

            Console.WriteLine("CarYearComparator:");

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            // Sort by model
            cars.Sort(new CarModelComparator());

            Console.WriteLine("\n===============\n");

            Console.WriteLine("CarModelComparator:");

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.ReadKey();
        }
    }
}
