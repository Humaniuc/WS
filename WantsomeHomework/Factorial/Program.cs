using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            uint number = ReadPositiveInteger("Write a positive number: ");
            Console.WriteLine("recursiveFactorial = " + RecursiveFactorial(5));
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

        private static long RecursiveFactorial(uint number)
        {
            if (number == 1)
            {
                return 1;
            }
            else
            {
                return number * RecursiveFactorial(number - 1);
            }
        
        }
    }
}
