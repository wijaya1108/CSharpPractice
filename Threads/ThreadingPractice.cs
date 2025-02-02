using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Threads
{
    public class ThreadingPractice
    {
        public void DoWork()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Separate thread number {i}");
                Thread.Sleep(1000);
            }
        }

        public void ExecuteThread()
        {
            Thread thread = new Thread(DoWork);
            thread.Start();

            Console.WriteLine("Main thread is running.....");

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Main thread number {i}");
                Thread.Sleep(1000);
            }
        }
    }
}
