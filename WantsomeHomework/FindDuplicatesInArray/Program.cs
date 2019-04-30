using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            uint nuElem = ReadPositiveInteger("Write a positive integer number: ");
        }

        private static uint ReadPositiveInteger(string text)
        {
            uint number;
            bool correct;

            Console.Write(text);
            do
            {
                correct = uint.TryParse(Console.ReadLine(), out number);
                if (!correct)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write(text);
                }
            } while (!correct);

            return number;
        }
    }
}
