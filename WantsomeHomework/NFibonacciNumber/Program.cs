using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFibonacciNumber
{
    class Program
    {
        private const double GoldenRatio = 1.61803398874989484820;

        static void Main(string[] args)
        {
            uint n = ReadPositiveInteger("Write a positive integer: ");
            Console.WriteLine($"The {n}{(n==1 ? "st" : (n==2)? "nd" : "th")} Fibonacci number is: {NFibonacci(GoldenRatio, n)}");
        }

        private static uint ReadPositiveInteger(string text)
        {
            uint n;
            bool correct;
            Console.Write(text);
            do
            {
                correct = uint.TryParse(Console.ReadLine(), out n);
                if (!correct)
                {
                    Console.WriteLine("invalid Input");
                    Console.Write(text);
                }
            } while (!correct);
            return n;
        }
        private static long NFibonacci(double goldenRatio, uint n)
        {
            long fibNum = (long)((Math.Pow(goldenRatio, n) - Math.Pow((1 - goldenRatio), n)) / Math.Sqrt(5));
            return fibNum;
        }
    }
}
