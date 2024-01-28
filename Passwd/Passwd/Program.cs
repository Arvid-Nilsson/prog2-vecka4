using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passwd = "Hej";
            string guess = null;
            Console.Write("Vad är lösenordet?: ");
           
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                guess += key.KeyChar;
            }
            Console.WriteLine("");
            if(guess == passwd)
            {
                Console.WriteLine("Hello world");
            }
            else
            {
                Console.WriteLine("Fel lösenord");
            }
        }
    }
}
