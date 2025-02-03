using CSharpPractice.Threads;

namespace CSharpPractice
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ThreadingPractice tp = new ThreadingPractice();
            var name = await tp.GetName();
            Console.WriteLine($"Name is {name}");
            Console.WriteLine("Main method is complete");
        }
    }
}
