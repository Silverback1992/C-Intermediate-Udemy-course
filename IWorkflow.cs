using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        IEnumerable<IActivity> GetActivities();
    }
}
