﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E20.SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ReadInteger("Write number of array elements: ", 0, int.MaxValue);
            int[] arr = CreateArray(number);
            PrintArray(arr);
            arr = SelectionSort(arr);
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

        private static int[] SelectionSort(int[] arr)
        {
            int min;

            for(int i = 0; i < arr.Length-1; i++)
            {
                min = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                Swap(ref arr[min], ref arr[i]);
            }

            return arr;
        }
    }
}
