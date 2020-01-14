using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            TimeOut = new TimeSpan(0, 0, 20);
        }

        public override void Close() => Console.WriteLine("Closing the connection to the SQL database. Connection string: {0}.", ConnectionString);

        public override void Open() => Console.WriteLine("Opening the connection to the SQL database. Connection string: {0}.", ConnectionString);
    }
}
