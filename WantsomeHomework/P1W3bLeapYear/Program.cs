using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1W3bLeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = ReadYear("Enter an year to check: ");
            Console.WriteLine("Method Framework: ");
            if(DateTime.IsLeapYear(d.Year))
            {
                Console.WriteLine($"{d.Year} is Leap Year");
            }
            else
            {
                Console.WriteLine($"{d.Year} is not Leap Year");
            }

            Console.WriteLine("Iterative method: ");
            if(LeapYear(d))
            {
                Console.WriteLine($"{d.Year} is Leap Year");
            }
            else
            {
                Console.WriteLine($"{d.Year} is not Leap Year");
            }

        }

        private static DateTime ReadYear(string text)
        {
            int year;
            bool correct = false;
            Console.Write(text);
            do
            {
                correct = int.TryParse(Console.ReadLine(), out year);
                if (!correct)
                {
                    Console.WriteLine("Incorect input");
                    Console.Write(text);
                }
            } while (!correct);
            DateTime d = new DateTime();
            d = d.AddYears(year - 1);
            return d;            
        }

        private static bool LeapYear(DateTime d)
        {
            if((d.Year % 400 == 0 || d.Year % 100 != 0) && (d.Year % 4 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
