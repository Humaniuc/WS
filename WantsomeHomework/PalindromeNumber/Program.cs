using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadNumber("Write an integer: ");
            if(Palindrome(number))
            {
                Console.WriteLine($"{number} is palindrome");
            }
            else
            {
                Console.WriteLine($"{number} is not palindrome");
            }

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

        private static bool Palindrome(int number)
        {
            string num = number.ToString();
            for(int i = 0, j = num.Length-1; i < j; i++, j--)
            {
                if(num[i] != num[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
