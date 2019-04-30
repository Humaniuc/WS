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
            int[] myArr = ReadArray(numToRead, -100, 100);
            PrintArray(myArr);

            Console.WriteLine($"Sum of even elements in this array is: {SumEven(myArr)}");
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

        private static int[] ReadArray(int numOfElements, int lowerLimit, int upperLimit)
        {
            Random rand = new Random();
            int[] myArr = new int[numOfElements];
            for(int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rand.Next(lowerLimit, upperLimit);
            }

            return myArr;
        }

        private static void PrintArray(int[] myArr)
        {
            for(int i = 0; i < myArr.Length; i++)
            {
                Console.Write($"{myArr[i]} ");
            }
            Console.WriteLine();
        }

        private static long SumEven(int[] myArr)
        {
            long sum = 0;
            for(int i = 0; i < myArr.Length; i++)
            {
                if(myArr[i] % 2 == 0)
                {
                    sum += myArr[i];
                }
            }
            return sum;
        }
    }
}
