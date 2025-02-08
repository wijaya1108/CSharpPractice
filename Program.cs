using System.Diagnostics;

namespace CSharpPractice
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            //int[] numbers = new int[3];
            //string[] names = new string[]
            //{
            //    "Hello",
            //    "Hi"
            //};
            ////[],[],[]

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //}

            //Console.WriteLine(numbers[0]);
            //Console.WriteLine(numbers[1]);
            //Console.WriteLine(numbers[2]);
            //Console.WriteLine("length of the array is {0}", numbers.Length);
            //Console.WriteLine("length of the string array is {0}", names.Length);

            //Lists
            //List<string> names = new List<string>();

            //names.Add("Ryan");
            //names.Add("Jack");

            //Console.WriteLine("Length of the list {0}", names.Count);

            //names[0] = "Name";

            //List<int> numbers = new() { 4 };

            //numbers.Insert(0, 2);

            //names.Sort();

            //names.Clear();

            //Console.WriteLine("Length of the list {0}", names.Count);

            //numbers.Remove(2);
            //names.Remove("Name");

            //Dictionaries
            Dictionary<string, int> wordsToNumbers = new Dictionary<string, int>();
            Dictionary<int, string> numbersToWords = new()
            {
                {1, "One" },
                {2, "two" },
                {3, "Three" }
            };

            wordsToNumbers.Add("one", 1);
            wordsToNumbers.Add("two", 2);

            Console.WriteLine(numbersToWords[1]);
            Console.WriteLine(wordsToNumbers["one"]);

            bool isAvailable = wordsToNumbers.ContainsKey("one");
            Console.WriteLine(isAvailable);

            bool isThere = wordsToNumbers.TryGetValue("ones", out int value);
            Console.WriteLine($"Availablity of key is {isThere}, and the value is {value}");

            bool isWordAvailable = numbersToWords.TryGetValue(2, out string? stringValue);
            Console.WriteLine($"Availablity of key is {isWordAvailable}, and the value is {stringValue}");
        }
    }
}
