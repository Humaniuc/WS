using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text: ");
            string str = Console.ReadLine();
            Console.WriteLine($"{str} with no duplicates is: {RemoveDuplicates(str)}");
        }

        private static string RemoveDuplicates(string str)
        {
            string rmstr = "";

            for (int j = 0; j < str.Length; j++)
            {
                if (!rmstr.Contains(str[j]))
                {
                    rmstr += str[j];
                }
                else
                {
                    continue;
                }
            }
            str = rmstr;
            return str;
        }
    }
}
