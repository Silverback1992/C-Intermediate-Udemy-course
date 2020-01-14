using System;
using System.Collections.Generic;
using System.Text;

namespace Intermediate
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (IActivity I in workflow.GetActivities())
            {
                I.Execute();
            }
        }
    }
}
