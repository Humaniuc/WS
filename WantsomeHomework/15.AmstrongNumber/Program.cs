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
            CheckArmstrongNumber(number);
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

        private static void CheckArmstrongNumber(int number)
        {
            int count = 0;
            int num = number;
            while (num != 0)
            {
                count++;
                num /= 10;
            }

            int sum = 0;
            num = number;
            while (num != 0)
            {
                sum += (int)Math.Pow(num % 10, count);
                num /= 10;
            }

            if (sum == number)
            {
                Console.WriteLine($"{number} is armstrong number");
            }
            else
            {
                Console.WriteLine($"{number} is not armstrong number");
            }
        }
    }
}
