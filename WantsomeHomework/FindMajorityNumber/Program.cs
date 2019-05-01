using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMajorityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int elements = ReadInteger("Write a positeive integer: ", 1, int.MaxValue);
            int[] myArr = CreateArray(elements);
            PrintArray(myArr);
            Console.WriteLine("Majority number: " + FindMajorityNumber(myArr));
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

        private static int FindMajorityNumber(int[] myArr)
        {
            int count = 1;
            int number = myArr[0];
            int i = 0;
            while (i < myArr.Length - 1)
            {
                for (int j = i + 1; j < myArr.Length; j++)
                {
                    number = myArr[j];
                    if (myArr[i] == myArr[j])
                    {
                        count++;
                        if (count > myArr.Length / 2)
                        {
                            break;
                        }
                    }
                }
                i++;
            }
            return number;
        }
    }
}
