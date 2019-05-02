using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumber("Write an integer: ");
        }

        private static int ReadNumber(string text)
        {
            int number;
            bool correct;
            Console.Write(text);
            do
            {
                correct = int.TryParse(Console.ReadLine(), out number);
                if (!correct)
                {
                    Console.WriteLine("Incorect input");
                    Console.Write(text);
                }
            } while (!correct);
            return number;
        }
    }
}
