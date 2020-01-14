using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            TimeOut = new TimeSpan(0, 0, 30);
        }

        public override void Close() => Console.WriteLine("Closing the connection to the Oracle database. Connection string: {0}.", ConnectionString);

        public override void Open() => Console.WriteLine("Opening the connection to the Oracle database. Connection string: {0}.", ConnectionString);
    }
}
