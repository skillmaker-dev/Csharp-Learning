using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Utilities<double>.Max(-4.2, -55));
        }
    }
}
