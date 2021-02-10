using System;

namespace _1001
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            var b = Console.ReadLine();

            var x = Convert.ToInt32(a) + Convert.ToInt32(b);

            Console.WriteLine($"X = {x}");
        }
    }
}