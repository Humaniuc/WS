using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnagramStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = CreateStrings();
        }

        private static string[] CreateStrings()
        {
            string[] strings = new string[2];
            Console.Write("Write firstString: ");
            strings[0] = Console.ReadLine();
            Console.Write("Write second string (same length like firstString): ");
            do
            {
                strings[1] = Console.ReadLine();
                if (strings[1].Length != strings[0].Length)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Write second string (same length like firstString): ");
                }
            } while (strings[1].Length != strings[0].Length);

            return strings;
        }
    }
}
