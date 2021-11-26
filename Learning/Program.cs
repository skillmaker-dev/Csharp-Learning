using System;
using System.IO;
using System.Collections.Generic;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = new DbCommand(new OracleConnection("sql string"), "INSERT INTO table...");
            command.Execute();
        }

        
    }


    
    
}
