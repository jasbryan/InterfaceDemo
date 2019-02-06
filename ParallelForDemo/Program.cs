using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelForDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //ParallelFor();
            //SequentialFor();
            //ThreadingThruTask();

            string[] messages = { "First Task", "Second task", "Third task", "Fourth task" };

            foreach (string msg in messages)
            {
                //var t = new Task((m) => printMessage((string)(m), msg);
                Task myTask = new Task( obj => printMessage( (string)obj), msg);
                myTask.Start();

            }

            Console.WriteLine("Main is done");
            Console.ReadLine();




        }

        static void printMessage(string msg)
        {
            Console.WriteLine("Msssage : {0} ", msg);
        }

        static void ParallelFor()
        {
            Console.WriteLine("Parallel For...");
            var watch = Stopwatch.StartNew();

            Parallel.For(2, 20, (i) =>
             {
                 Console.WriteLine($"root:{i}, sunRootN:{SumRootN(i)}");
             });
            Console.WriteLine($"time: {watch.Elapsed}");

        }

        static void SequentialFor()
        {
            Console.WriteLine("SequentialFor....");
            var watch = Stopwatch.StartNew();
            for (int i = 2; i < 20; i++)
            {
                Console.WriteLine($"root:{i}, sunRootN:{SumRootN(i)}");
            }
            Console.WriteLine($"time: {watch.Elapsed}");
        }

        static double SumRootN (int root)
        {
            double result = 0;
            for(int i=1;i<10000000;i++)
            {
                result += Math.Exp(Math.Log(i) / root);
            }
            return result;
        }

        static void ThreadingThruTask()
        {
            var t1 = new Task( () =>
            {
                Console.WriteLine("I am a task running");
            });

            t1.Start();
            Console.WriteLine("I am moving on..");
        }
    }
}
