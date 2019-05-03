using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E21.BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInteger("Write number of array elements: ", 0, int.MaxValue);
            int[] arr = CreateArray(number);
            Console.Write("Unsorted: ");
            PrintArray(arr);
            BubbleSort(arr);
            Console.Write("Sorted: ");
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

        private static void Swap(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a = a - b;
        }

        private static void BubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length-1; i++)
            {
                for(int j = 0; j < arr.Length-1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                    }
                }
            }
        }
    }
}
