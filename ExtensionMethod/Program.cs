using System;

namespace ExtensionMethod
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Type word to reverse...");
            var toReverse = Console.ReadLine();

            var reversed = toReverse.ReverseString();

            Console.WriteLine($"Reversed word {toReverse} is: {reversed}");
            Console.ReadKey();
        }
    }
}
