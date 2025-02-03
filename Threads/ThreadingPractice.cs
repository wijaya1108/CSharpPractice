using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice.Threads
{
    public class ThreadingPractice
    {
        public async Task DoWork()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Separate thread number {i}");
                await Task.Delay(1000);
            }
        }

        //public void ExecuteThread()
        //{
        //    Thread thread = new Thread(DoWork);
        //    thread.Start();

        //    Console.WriteLine("Main thread is running.....");

        //    for (int i = 0; i <= 5; i++)
        //    {
        //        Console.WriteLine($"Main thread number {i}");
        //        Thread.Sleep(1000);
        //    }
        //}


        public async Task ExecuteTaskMethod()
        {
            await Task.Run(() => DoWork());
            //task.Wait(); //blocks the execution until task is completed

            Console.WriteLine("Main method is complete");
        }

        public async Task<string> GetName()
        {
            Console.WriteLine("Waiting.....");
            await Task.Delay(1500);
            return "Hello async programming";
        }

    }
}
