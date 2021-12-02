using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_example
{
    //using delegate:
    //public delegate void SayAllDelegate();
       
    class SayAll
    {
        //Using delegate:
        //public SayAll(SayAllDelegate sayAll)

        //using Action generic class:
        public SayAll(Action sayAll)
        {
            sayAll();
        }
    }
}
