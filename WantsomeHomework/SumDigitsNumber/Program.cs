using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigitsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInteger("Enter an integer number: ");
        }

        private static int ReadInteger(string text)
        {
            int number;
            bool correct;
            Console.Write(text);
            do
            {
                correct = int.TryParse(Console.ReadLine(), out number);
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
