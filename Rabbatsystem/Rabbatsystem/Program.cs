using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabbatsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rabbat = 0;
            Console.Write("Hur gammal är du?: ");
            int ålder = int.Parse(Console.ReadLine());
            Console.Write("är du student? (y, n): ");
            char student = char.Parse(Console.ReadLine());
            string rabbatTyp = "";
            if (student.Equals('y'))
            {
                rabbat = 20;
                rabbatTyp = "Studentrabbat";
            }
            else if(ålder > 65)
            {
                rabbat = 15;
                rabbatTyp = "Pensionärsrabbat";
            }
            else if (ålder < 18)
            {
                rabbat = 10;
                rabbatTyp = "Ungdomsrabbat";
            }

            if(rabbat != 0)
            {
                Console.WriteLine($"din rabbat är {rabbat}% {rabbatTyp}");
            }
            else
            {
                Console.WriteLine("Du får ej en rabbat, bli student");
            }
        
        }
    }
}
