using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    abstract class DbConnection
    {
        protected string ConnectionString { get; set; }
        protected TimeSpan Timeout { get; set; }

        public DbConnection(String connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentNullException("Connection string is null");
            
            ConnectionString = connectionString;
        }

        abstract public void OpenConnection();
        abstract public void CloseConnection();

    }
}
