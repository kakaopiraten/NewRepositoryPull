using System;

namespace Collaboration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double userInputNumber = 0;
            double.TryParse(Console.ReadLine(), out userInputNumber);
            Console.WriteLine(userInputNumber);

            userInputNumber += Math.PI;

            Console.WriteLine(userInputNumber);
        }
    }
}
