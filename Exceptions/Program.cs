using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("This is message before throwing exception");
                throw new Exception("This is an exception");
                Console.WriteLine("This is message after throwing exception"); //Note that this message didn't show up in console
            }
            catch (Exception ex) // Exception is thrown to ex parameter
            {
                //Code inside catch is executed whenever there is an exception
                Console.WriteLine(ex.Message); //we got the exception message
                Console.WriteLine("This is a message inside Catch");
            }
            finally
            {
                Console.WriteLine("This is a message inside Finally");  //Code inside finally is always executed 
            }

            Console.WriteLine("This is a message outside try catch blocks");
        }
    }
}
