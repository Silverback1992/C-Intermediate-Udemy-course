using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class SendMail : IActivity
    {
        public void Execute() => Console.WriteLine("Sending mail.");
    }
}
