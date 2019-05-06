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
            Console.WriteLine("Before rotate: ");
            PrintArray(arr);
 
            arr = PivotRotate(arr);
            Console.WriteLine("After rotate: ");
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

        private static int[] PivotRotate(int[] arr)
        {
            int pivot = ReadInteger($"Write a number between {0} and {arr.Length - 1}: ", 0, arr.Length - 1);
            int[] myArr = new int[arr.Length];

            for(int i = arr.Length-1, j = 0 ; i > pivot || j <= pivot; i--, j++)
            {
                myArr[j] = arr[i];
                myArr[i] = arr[j];
            }
            return myArr;
        }
    }
}
