using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class DbCommand
    {
        private DbConnection Connection { get; set; }
        private string Insturction { get; set; }
        
        public DbCommand(DbConnection connection, string instruction)
        {
            if (connection == null)
                throw new ArgumentNullException("Connection can not be null.");

            if (String.IsNullOrEmpty(instruction))
                throw new ArgumentException("Instruction can not be null or empty string.");

            Connection = connection;
            Insturction = instruction;
        }

        public void Execute()
        {
            Connection.Open();
            Console.WriteLine("Instruction {0} has run.", Insturction);
            Connection.Close();
        }
    }
}
