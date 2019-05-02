using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSetedBits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInteger("Write an integer number: ");
            Console.WriteLine($"Number {number} has {SetedBitsCount(number)} seted bits");
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
        private static int SetedBitsCount(int number)
        {
            int count = 0;
            for(int i = 0; i < 32; i++)
            {
                if((number & (1 << i)) != 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
