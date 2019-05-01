using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numElemArrayA = ReadInteger("Write first array's number elements: ", 1, int.MaxValue);
            int numElemArrayB = ReadInteger("Write second array's number elements: ", 1, int.MaxValue);
            int[] arrA = CreateArray(numElemArrayA, 'A');
            int[] arrB = CreateArray(numElemArrayB, 'B');

            LinkedList<int> listA = new LinkedList<int>(arrA);
            LinkedList<int> listB = new LinkedList<int>(arrB);

            Console.Write("List A: ");
            PrintList(listA);
            Console.Write("List B: ");
            PrintList(listB);
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

        private static int[] CreateArray(int elements, char c)
        {
            int[] myArr = new int[elements];
            for(int i = 0; i< myArr.Length; i++)
            {
                myArr[i] = ReadInteger($"{c}[{i}]= ", int.MinValue, int.MaxValue);
            }
            return myArr;
        }

        private static void Swap(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }
        private static void SortArray(int[] arr)
        {
            for(int i = 0; i < arr.Length - 1; i++)
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

        private static void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        private static LinkedList<int> CreateSortedList(int[] arr)
        {
            SortArray(arr);
            LinkedList<int> list = new LinkedList<int>(arr);
            
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
