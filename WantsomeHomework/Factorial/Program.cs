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
            Console.WriteLine("recursiveFactorial = " + RecursiveFactorial(number));
            Console.WriteLine("iterativeFactorial = " + IterativeFactorial(number));
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

        private static long IterativeFactorial(uint number)
        {
            long factorial = number;
            for(uint i = number-1; i > 1; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
