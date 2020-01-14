using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class StackOverflowPost
    {
        private string Name { get; set; }
        private string Description { get; set; }
        private DateTime CreateTime { get; set; }
        private int Votes { get; set; }

        public StackOverflowPost(string name, string description, DateTime createTime)
        {
            Name = name;
            Description = description;
            CreateTime = createTime;
        }

        public void UpVote() => Votes++;
        public void DownVote() => Votes--;
        public void PrintVotes() => Console.WriteLine("Vote status: {0}", Votes);
    }
}
