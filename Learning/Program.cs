using System;
using System.IO;
using System.Collections.Generic;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = new SqlConnection("SQL string");
            var oracle = new OracleConnection("ORACLE string");

            sql.OpenConnection();
            oracle.OpenConnection();
            sql.CloseConnection();
            oracle.CloseConnection();
        }

        
    }


    
    
}
