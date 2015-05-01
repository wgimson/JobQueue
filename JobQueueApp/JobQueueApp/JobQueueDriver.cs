using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobQueueApp
{
    public class JobQueueDriver
    {
        public static void Main(string[] args)
        {
            JobProcessing queue = new JobProcessing();
            Console.Write(queue.ToString());
            queue.AddJob("Sam's Job");
            queue.AddJob("Frodo's Job");
            queue.AddJob("Bilbo's Job");
            Console.Write(queue.ToString());
            queue.AddJob("Gandalf's Job");
            queue.AddJob("Shelob's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");
            queue.AddJob("Alex's Job");

            Console.Write(queue.ToString());

            queue.AddJob("Billy's Job");
            Console.Write(queue.ToString());

            queue.AddJob("Billy's Job");
            queue.AddJob("Billy's Job");
            queue.AddJob("Billy's Job");
            queue.AddJob("Billy's Job");
            Console.Write(queue.ToString());
        }
    }
}