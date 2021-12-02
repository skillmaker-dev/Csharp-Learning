using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generics
{
    class Utilities<T> where T : IComparable
    {
        
        public Utilities()
        {
            
        }

        public static T Max(T a,T b)
        {
            return (a.CompareTo(b) < 0) ? b : a;
        }
    }
}
