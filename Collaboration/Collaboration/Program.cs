using System;

namespace Collaboration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double userInput = 5;
            double.TryParse(Console.ReadLine(), out userInput);
            Console.WriteLine(userInput);
        }
    }
}
