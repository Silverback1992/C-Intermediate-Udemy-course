using System;

namespace Intermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            //Stopwatch
            Console.WriteLine("Stopwatch:");
            Utility.StopWatchTesting();
            Console.WriteLine();

            //StackOverflow Post
            Console.WriteLine("StackOverflow Post:");
            Utility.StackOverflowPostTesting();
            Console.WriteLine();

            //Custom Stack
            Console.WriteLine("Custom Stack:");
            Utility.CustomStackTesting();
            Console.WriteLine();

            //Database Connection
            Console.WriteLine("Database Connection:");
            Utility.DatabaseConnectionTesting();
            Console.WriteLine();

            //Database Command
            Console.WriteLine("Database Command:");
            Utility.DatabaseCommandTesting();
            Console.WriteLine();

            //Workflow Engine
            Console.WriteLine("Workflow Engine:");
            Utility.WorkflowEngineTesting();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
