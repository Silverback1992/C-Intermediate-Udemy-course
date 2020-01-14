using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public static class Utility
    {
        public static void CustomStackTesting()
        {
            //Testing the custom stack
            var stack = new CustomStack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine("Popping: {0}", stack.Pop());
            Console.WriteLine("Popping: {0}", stack.Pop());
            Console.WriteLine("Popping: {0}", stack.Pop());

            stack.Push(4);
            stack.Push(5);
            stack.Push(6);

            Console.WriteLine("Top value is: {0}", stack.Top());

            stack.Clear();
            Console.WriteLine("Top value is: {0}", stack.Top());
        }

        public static void DatabaseConnectionTesting()
        {
            var sql = new SqlConnection("SQL_C_O_N:35");
            var oracle = new OracleConnection("ORACLE$C$O$N$999");
            sql.Open();
            oracle.Open();
            sql.Close();
            oracle.Close();

            //var sqlError = new SqlConnection("");
            //var oracleError = new OracleConnection(null);
        }

        public static void WorkflowEngineTesting()
        {
            var workflow = new Workflow();
            workflow.Add(new UploadVideoToCloud());
            workflow.Add(new CallWebService());
            workflow.Add(new SendMail());
            workflow.Add(new ChangeStatus());

            var engine = new WorkflowEngine();
            engine.Run(workflow);
        }

        public static void DatabaseCommandTesting()
        {
            var sql = new SqlConnection("SQL_C_O_N:420");
            var oracle = new OracleConnection("ORACLE$C$O$N$69");

            var commandSQL = new DbCommand(sql, "SELECT * FROM EVERYTHING");
            var commandOracle = new DbCommand(oracle, "DROP EVERY TABLE");
            commandSQL.Execute();
            commandOracle.Execute();
        }

        public static void StackOverflowPostTesting()
        {
            //Creating an object, upvoting, downvoting, and displaying the value a few times.
            var post = new StackOverflowPost("When do we use interfaces?", "Some description.", DateTime.Now);
            post.PrintVotes();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            post.DownVote();
            post.UpVote();
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.PrintVotes();
        }
        public static void StopWatchTesting()
        {
            //General check
            Console.WriteLine("General check:");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            TimeWaster();
            stopwatch.End();
            stopwatch.PrintDuration();

            //Starting with ending
            Console.WriteLine("Starting with ending:");
            stopwatch.End();
            stopwatch.Start();
            TimeWaster();
            stopwatch.End();
            stopwatch.PrintDuration();

            //Using end twice
            Console.WriteLine("Using end twice:");
            stopwatch.Start();
            TimeWaster();
            stopwatch.End();
            TimeWaster();
            TimeWaster();
            stopwatch.End();
            stopwatch.PrintDuration();

            //Using print duration without start and end
            Console.WriteLine("Using print duration without start and end");
            stopwatch.PrintDuration();

            //Two start
            //Console.WriteLine("Using start twice:");
            //stopwatch.Start();
            //stopwatch.Start();
        }
        private static void TimeWaster()
        {
            for (int i = 0; i < 1000000000; i++)
            {

            }
        }
    }
}
