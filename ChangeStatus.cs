using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class ChangeStatus : IActivity
    {
        public void Execute() => Console.WriteLine("Changing status.");
    }
}
