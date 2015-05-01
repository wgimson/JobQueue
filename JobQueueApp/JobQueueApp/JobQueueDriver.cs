using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JobQueueApp.Extensions;

namespace JobQueueApp
{
    public class JobQueueDriver
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("<!------------JOB QUEUE EMPTY AND INITIALIZED TO DEFAULT LENGTH 16------------>\n");
            JobProcessing queue = new JobProcessing(2);
            for (var i = 0; i < 16; i++)
            {
                queue.AddJob("Alex's Job");
            }
            Console.Write(queue.ToString());

            Console.WriteLine("<!-----------JOB QUEUE LENGTH SHOULD INCREASE NOW BY FACTOR SIZE--------------->\n");
            queue.AddJob("Billy's Job");
            Console.Write(queue.ToString());

            Console.WriteLine("<!-----------NOW A JOB IS CONSUMED FOR EVERY JOB ADDED, SO QUEUE SHOULD NOT GROW AT ALL-------------->\n");
            for (var i = 0; i < 32; i++)
            {
                queue.GetAndAddJob("Steve");
            }
            Console.Write(queue.ToString());
        }
    }
}