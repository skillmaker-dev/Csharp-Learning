using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Cars
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public static List<Cars> GetCars()
        {
            return new List<Cars> { new Cars { Name = "Toyota", Price = 30.6d },
                                     new Cars { Name = "Mercedes", Price = 60.6d },
                                     new Cars { Name = "Mazda", Price = 45.6d },
                                     new Cars { Name = "Ford", Price = 20.9d },
                                     new Cars { Name = "Chevrolet", Price = 50.6d }
            };
        }
    }
}
