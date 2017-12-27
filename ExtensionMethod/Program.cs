using System;

namespace ExtensionMethod
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Type word to reverse...");
            var toReverse = Console.ReadLine();

            var reversed = toReverse.StringReverse();

            Console.WriteLine("Reversed word {0} is: {1}", toReverse, reversed);
            Console.ReadKey();
        }
    }
}
