using CSharpPractice.Enums;
using CSharpPractice.Struct;
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
            //Dictionary<string, int> wordsToNumbers = new Dictionary<string, int>();
            //Dictionary<int, string> numbersToWords = new()
            //{
            //    {1, "One" },
            //    {2, "two" },
            //    {3, "Three" }
            //};

            //wordsToNumbers.Add("one", 1);
            //wordsToNumbers.Add("two", 2);

            //Console.WriteLine(numbersToWords[1]);
            //Console.WriteLine(wordsToNumbers["one"]);

            //bool isAvailable = wordsToNumbers.ContainsKey("one");
            //Console.WriteLine(isAvailable);

            //bool isThere = wordsToNumbers.TryGetValue("ones", out int value);
            //Console.WriteLine($"Availablity of key is {isThere}, and the value is {value}");

            //bool isWordAvailable = numbersToWords.TryGetValue(2, out string? stringValue);
            //Console.WriteLine($"Availablity of key is {isWordAvailable}, and the value is {stringValue}");

            //reference type
            //List<string> names = new()
            //{
            //    "John",
            //    "Nick"
            //};

            //void DoSomethingWithTheReference(List<string> nameList)
            //{
            //    nameList.Add("Tim");
            //    nameList.Add("Smith");
            //}

            //Console.WriteLine("Before passed into the method: ");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //DoSomethingWithTheReference(names);

            //Console.WriteLine("After passed into the method");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////value type
            //Console.WriteLine("==========================");
            //Console.WriteLine("==========================");

            //string man = "Nick Ed";

            //void DoSomethingWithTheValueType(ref string newName)
            //{
            //    newName = "Jack Reacher";
            //}

            //Console.WriteLine("Before the method:");
            //Console.WriteLine(man);

            //DoSomethingWithTheValueType(ref man);

            //Console.WriteLine("After the method:");
            //Console.WriteLine(man);

            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine(a);

            //List<int> names = new() { 10, 20 };
            //var newNames = names;

            //Console.WriteLine("Before");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //newNames.Remove(10);

            //Console.WriteLine("After");
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //enums
            //DaysOfWeek today = DaysOfWeek.Tuesday;
            //Console.WriteLine(today);

            //int todayIntVal = (int)today;
            //Console.WriteLine("Int value of today: {0}", todayIntVal);

            //StatusCodes status = StatusCodes.Success;
            //Console.WriteLine(status);

            //int statusCode = (int)StatusCodes.Success;
            //Console.WriteLine(statusCode);

            //struct
            void DomSomethingWithTheStruct(Point p)
            {
                p.X = 100;
                p.Y = 200;
            }

            Point point = new Point()
            {
                X = 10,
                Y = 20
            };

            Console.WriteLine($"Before passing to method X = {point.X}, Y = {point.Y}");
            DomSomethingWithTheStruct(point);
            Console.WriteLine($"After passing to method X = {point.X}, Y = {point.Y}");
        }
    }
}
