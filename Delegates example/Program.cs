using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using delegate:
            //SayAllDelegate functions;

            //using Action generic class:
            Action functions;
            functions = Functions.SayHello;
            functions += Functions.SayWelcome;
            functions += Functions.SayGoodBye;

            new SayAll(functions);
        }
    }
}
