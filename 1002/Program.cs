using System;

namespace _1002
{
    class Program
    {
        // NÃO RESOLVIDO
        static void Main(string[] args)
        {
            decimal pi = 3.14159M;
            decimal raio = Convert.ToDecimal(Console.ReadLine().Replace('.',','));

            decimal area = pi * raio * raio;

            string result = Math.Round(area, 4).ToString().Replace(',', '.');

            Console.WriteLine($"A={result}"); 
        }
    }
}