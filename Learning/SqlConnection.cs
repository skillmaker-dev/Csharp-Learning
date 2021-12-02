using System;
using System.Collections.Generic;
using System.Text;

namespace Learning_Basics
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(String connectionString) : base(connectionString)
        {
            ConnectionString = connectionString;
            Timeout = new TimeSpan(0, 2, 0);
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Sql Connection closed at {0} with connectionString: {1}",DateTime.Now, ConnectionString);
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Sql Connection opened at {0} with connectionString: {1} and Timeout of {2}", DateTime.Now, ConnectionString, Timeout.ToString());
        }
    }
}
