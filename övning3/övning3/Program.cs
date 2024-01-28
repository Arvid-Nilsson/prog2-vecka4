using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace övning3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] heltal = { 1, 5, 6, 8, 10 };
            int sum = 0;

            //Skriv ut arrayen
            foreach(int i in heltal)
            {
                Console.WriteLine(i);
                sum = sum + i;
            }

            Console.WriteLine($"summan är {sum}");

            //dubbla värden
            for(int i = 0;i< heltal.Length; i++)
            {
                int value = heltal[i];
                heltal[i] = value * 2;
            }

            Console.WriteLine("Dubbla");
            //Skriv ut arrayen med de dubbla värdena
            foreach(int i in heltal)
            {
                Console.WriteLine(i);
            }

        }
    }
}
