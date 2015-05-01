using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobQueueApp.Extensions
{
    public static class JobQueueExtensions
    {
        public static void GetAndAddJob(this JobProcessing jobQueue, string newJob)
        {
            jobQueue.AddJob(newJob);
            jobQueue.GetNextJob();
        }
    }
}