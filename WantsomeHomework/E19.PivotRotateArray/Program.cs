using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E19.PivotRotateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInteger("Write number of array elements: ", 0, int.MaxValue);
            int[] arr = CreateArray(number);
            PrintArray(arr);
        }

        private static int ReadInteger(string text, int lowerLimit, int upperLimit)
        {
            int elements;
            bool correct;
            Console.Write(text);
            do
            {
                correct = int.TryParse(Console.ReadLine(), out elements);
                if (!correct || elements < lowerLimit || elements > upperLimit)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write(text);
                }
            } while (!correct || elements < lowerLimit || elements > upperLimit);
            return elements;
        }

        private static int[] CreateArray(int elements)
        {
            int[] myArr = new int[elements];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = ReadInteger($"myArr[{i}]= ", int.MinValue, int.MaxValue);
            }

            return myArr;
        }

        private static void PrintArray(int[] myArr)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                Console.Write($"{myArr[i]} ");
            }
            Console.WriteLine();
        }
    }
}
