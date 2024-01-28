using System;

namespace övning2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pris = 0;
            Console.Write("Hur gammal är du?: ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder >= 120)
            {
                pris = 49.99;
            }
            else if (ålder <= 5)
            {
                pris = 0;
            }
            else
            {
                pris = 99.99;
            }
            Console.WriteLine($"Ditt pris är {pris}kr habibi");

        }
    }
}
