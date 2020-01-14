using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class CallWebService : IActivity
    {
        public void Execute() => Console.WriteLine("Calling web service.");
    }
}
