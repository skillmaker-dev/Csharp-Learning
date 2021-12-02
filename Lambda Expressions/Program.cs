using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(){ 1,2,3,4,5,6,7,8};
            var GreaterThan3 = numbers.FindAll(n => n > 3);
            // a => expression;
            // (a,b) => expression;
            // () => expression;
            // a => { statements };



            foreach (var num in GreaterThan3)
            {
                Console.WriteLine(num);
            }
            
        }
    }
}
