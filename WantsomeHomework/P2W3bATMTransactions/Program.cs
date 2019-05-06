using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2W3bATMTransactions
{
    class Program
    {
        static void Main(string[] args)
        {
            uint amount = 0;
            uint choice = ReadChoice("1 - BalaceCheck; 2 - CashWithdraw; 3 - CashFeed; 0 - Exit: -> ");
            while (choice == 1 || choice == 2 || choice == 3)
            {
                switch (choice)
                {
                    case 1:
                        BalaceCheck(amount);
                        break;
                    case 2:
                        CashWithdraw(ref amount);
                        break;
                    case 3:
                        uint num = 0;
                        do
                        {
                            num = CashFeed(ref amount);
                        } while (num != 0);
                        break;
                    case 0:
                        break;
                }
                choice = ReadChoice("1 - BalaceCheck; 2 - CashWithdraw; 3 - CashFeed; 0 - Exit; -> ");
            }            
        }


        private static uint ReadChoice(string text)
        {
            uint choice;
            bool correct;
            uint[] choices = { 1, 2, 3, 0};
            List<uint> list = new List<uint>(choices);
            Console.Write(text);
            do
            {
                correct = uint.TryParse(Console.ReadLine(), out choice);
                if (!correct || !list.Contains(choice))
                {
                    Console.WriteLine("Invalid input");
                    Console.Write(text);
                }
            } while (!correct || !list.Contains(choice));
            return choice;
        }
        private static uint ReadAmount(string text, uint lowerLimit, uint amount)
        {
            uint num;
            bool correct = false;
            Console.Write(text);
            do
            {
                correct = uint.TryParse(Console.ReadLine(), out num);
                if (num < lowerLimit)
                {
                    Console.WriteLine("The amount you want to withdraw is smaller than minim amount you could withdraw.");
                    Console.Write(text);
                }
                else if (num > amount)
                {
                    Console.WriteLine("The amount you want to withdraw is bigger than amount you have");
                    Console.Write(text);
                }
                if (!correct)
                {
                    Console.WriteLine("Invalid input");
                    Console.Write(text);
                }
            } while (!correct || num > amount || num < lowerLimit);
            return num;
        }

        private static uint ReadBancnote(string text)
        {
            uint[] acceptedBancnotes = { 0, 1, 5, 10, 50, 100, 200, 500 };
            List<uint> list = new List<uint>(acceptedBancnotes);
            uint num;
            bool correct = false;
            Console.WriteLine(text);
            do
            {
                correct = uint.TryParse(Console.ReadLine(), out num);
                if (!correct || !list.Contains(num))
                {
                    Console.WriteLine("Invalid Bancnote");
                    Console.WriteLine(text);
                }
            } while (!correct || !list.Contains(num));

            return num;
        }

        private static void BalaceCheck(uint amount)
        {
            Console.WriteLine($"You have {amount} in your cont");
        }
        private static void CashWithdraw(ref uint amount)
        {
            uint num = ReadAmount("How much you want to withdraw? ", 0, amount);

            amount -= num;
        }

        private static uint CashFeed(ref uint amount)
        {

            uint num = ReadBancnote("Enter amount you feed? ");
            amount += num;
            return num;
        }
    }
}
