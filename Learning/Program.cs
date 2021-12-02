using System;
using System.IO;
using System.Collections.Generic;

namespace Learning_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlowEngine = new WorkFlowEngine(new Workflow());
            workFlowEngine.Run();
        }

        
    }


    
    
}
