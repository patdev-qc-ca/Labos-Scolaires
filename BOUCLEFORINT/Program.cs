using System;

namespace BoucleForInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            for (int x = 0; x < 42; x++) {
                Console.WriteLine($"{x} = {x * 3 + 6}");

            }
        }
    }
}
