using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class Stopwatch
    {
        private TimeSpan Duration { get; set; }
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }
        private bool IsStarted { get; set; }
        private bool IsFinished { get; set; }

        public void Start()
        {
            if (IsStarted)
                throw new InvalidOperationException("Stopwatch already started.");

            StartTime = DateTime.Now;
            IsStarted = true;
        }

        public void End()
        {
            if (IsStarted)
            {
                EndTime = DateTime.Now;
                Duration = EndTime.Subtract(StartTime);
                IsStarted = false;
                IsFinished = true;
            }
        }

        public void PrintDuration()
        {
            if (IsFinished)
            {
                Console.WriteLine("Duration was: {0}", Duration);
                IsFinished = false;
            }
            else
                Console.WriteLine("Stopwatch was not started and ended properly.");
        }
    }
}
