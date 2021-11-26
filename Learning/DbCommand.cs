using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class DbCommand
    {
        private DbConnection _dbConnection;
        private string _query;
        public DbCommand(DbConnection dbConnection,String query)
        {
            if (dbConnection == null || String.IsNullOrEmpty(query))
                throw new ArgumentNullException("dbConnection or query is null");

            _dbConnection = dbConnection;
            _query = query;
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine("Data successfully inserted");
            _dbConnection.CloseConnection();
        }
    }
}
