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
            int numberToRead = ReadInteger("Write an integer");
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

        private static int[] ReadArray(int numElem, int lowerLimit, int upperLimit)
        {
            int[] myArr = new int[numElem];
            for(int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = ReadInteger($"myArr[{i}]= ");
            }
            return myArr;
        }
    }
}