using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods
{
    public static class StringExtensions
    {
        public static string Shorten(this string str,int numOfWords)
        {
            if (numOfWords < 0)
                throw new ArgumentOutOfRangeException("Number of words should be >= 0");

            var splitted = str.Split(' ');
            if (numOfWords >= splitted.Length)
                return str;

            return string.Join(" ",splitted.Take(numOfWords)) + "...";
        }
    }
}
