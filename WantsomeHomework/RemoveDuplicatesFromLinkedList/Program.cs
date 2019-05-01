using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesFromLinkedList
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

        private static LinkedList<int> CreateList()
        {
            Console.WriteLine("Press enter to continue reading!");
            LinkedList<int> list = new LinkedList<int>();
            do
            {
                LinkedListNode<int> node = new LinkedListNode<int>(ReadInteger("Write an list element: ", int.MinValue, int.MaxValue));
                list.AddLast(node);
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
            Console.WriteLine();
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
