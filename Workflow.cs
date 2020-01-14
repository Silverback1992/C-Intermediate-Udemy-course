using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class Workflow : IWorkflow
    {
        private readonly List<IActivity> activities;

        public Workflow() => activities = new List<IActivity>();

        public void Add(IActivity activity) => activities.Add(activity);

        public void Remove(IActivity activity) => activities.Remove(activity);

        public IEnumerable<IActivity> GetActivities() => activities;
    }
}
