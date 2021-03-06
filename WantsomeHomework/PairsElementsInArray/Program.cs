﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = ReadInteger("Write number of array elements: ");
            int[] myArr = ReadArray(numberToRead);

            int numberPairs = ReadInteger("Write a number to find his pairs elements sum:  ");

            FindPairs(myArr, numberPairs);
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

        private static int[] ReadArray(int numElem)
        {
            int[] myArr = new int[numElem];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = ReadInteger($"myArr[{i}]= ");
            }
            return myArr;
        }

        private static void FindPairs(int[] myArr, int pairSum)
        {
            for(int i = 0; i < myArr.Length-1; i++)
            {
                for(int j = i+1; j< myArr.Length; j++)
                {
                    if(myArr[i] + myArr[j] == pairSum)
                    {
                        Console.WriteLine($"{myArr[i]} + {myArr[j]} = {pairSum}");
                    }
                }
            }
        }
    }
}
