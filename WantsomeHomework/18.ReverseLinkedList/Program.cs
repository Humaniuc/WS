using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E18.ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = CreateList();
            PrintList(list);
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

        private static int[] CreateArray(int number)
        {
            int[] myArr = new int[number];
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = ReadInteger($"listNode{i}= ", int.MinValue, int.MaxValue);
            }
            return myArr;
        }

        private static LinkedList<int> CreateList()
        {
            int number = ReadInteger("Enter number of list elements: ", 0, int.MaxValue);

            int[] myArr = CreateArray(number);
            LinkedList<int> list = new LinkedList<int>(myArr);

            return list;
        }

        private static void PrintList(LinkedList<int> list)
        {
            foreach (int node in list)
            {
                Console.Write($"{node} ");
            }
            Console.WriteLine();
        }

    }
}
