using System;
using System.IO;
using System.Collections.Generic;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("stopwatch started");
            sw.Stop();
            Console.WriteLine("stopwatch stopped");
            sw.Stop();
            Console.WriteLine("stopwatch stopped");
            

                Console.ReadLine();
            //sw.Start();

            

            Console.WriteLine("Duration is {0}",sw.Duration);
            
        }

        
    }


    
    
}
