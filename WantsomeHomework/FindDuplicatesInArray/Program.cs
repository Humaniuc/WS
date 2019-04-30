using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDuplicatesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numElem = ReadPositiveInteger("Write a positive integer number: ");
            int[] myArr = CreateArray(numElem);
            PrintArray(myArr);
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

        private static int[] CreateArray(uint numElem)
        {
            int[] myArr = new int[numElem];
            for(int i = 0; i< myArr.Length; i++)
            {
                myArr[i] = ReadInteger($"myArr[{i}]= ", int.MinValue, int.MaxValue);
            }
            return myArr;
        }

        private static int ReadInteger(string text, int lowerLimit, int upperLimit)
        {
            int number;
            bool correct;
            Console.Write(text);
            do
            {
                correct = int.TryParse(Console.ReadLine(), out number);
                if (!correct || number < lowerLimit || number > upperLimit)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write(text);
                }
            } while (!correct || number < lowerLimit || number > upperLimit);

            return number;
        }

        private static void PrintArray(int[] myArr)
        {
            for(int i = 0; i < myArr.Length; i++)
            {
                Console.Write($"{myArr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
