using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public abstract class DbConnection
    {
        protected string ConnectionString { get; private set; }
        protected TimeSpan TimeOut { get; set; }
        public DbConnection(string connectionString)
        {
            if (String.IsNullOrEmpty(connectionString))
                throw new ArgumentException("You must supply a connection string.");
            
            ConnectionString = connectionString;
        }

        abstract public void Open();
        abstract public void Close();
    }
}
