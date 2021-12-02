using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Basics
{
    class EmailNotifier : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("The video started processing");
        }
    }
}
