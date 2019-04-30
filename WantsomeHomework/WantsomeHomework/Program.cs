using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantsomeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            int numToRead = ReadInteger("Write an integer number: ");
        }

        private static int ReadInteger(string text)
        {
            bool correct;
            int numberToRead;
            do
            {
                Console.Write(text);
                correct = int.TryParse(Console.ReadLine(), out numberToRead);
                if (!correct)
                {
                    Console.WriteLine("Invalid Input");
                    Console.Write(text);
                }
            } while (!correct);

            return numberToRead;
        }
    }
}
