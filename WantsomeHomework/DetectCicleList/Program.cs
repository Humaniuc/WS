using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectCicleList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numElements = ReadInteger("Write a positive integer: ", 1, int.MaxValue);
            int[] myArr = CreateArray(numElements);
            LinkedList<int> list = CreateList(myArr);
            PrintList(list);
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
        private static LinkedList<int> CreateList(int[] myArr)
        {
            LinkedList<int> list = new LinkedList<int>(myArr);
            
            return list;
        }

        private static void PrintList(LinkedList<int> list)
        {
            foreach(int node in list)
            {
                Console.Write($"{node} ");
            }
            Console.WriteLine();
        }
    }
}
