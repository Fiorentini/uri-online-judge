using System;

namespace _1003
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());

            var test = a + b;

            Console.WriteLine($"SOMA = {test}");
        }
    }
}
