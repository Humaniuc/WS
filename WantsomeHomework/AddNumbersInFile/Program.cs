using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddNumbersInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"..\..\Numbers.txt";
            int firstNum = 0;
            int secondNum = 0;
            try
            {
                StreamReader sr = new StreamReader(fileName); 
                using (sr)
                {
                    firstNum = Convert.ToInt32(sr.ReadLine());
                    secondNum = Convert.ToInt32(sr.ReadLine());
                }
            }catch(FileNotFoundException)
            {
                Console.Error.WriteLine("Can't find file {0}", fileName);
            }catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid Directory in file path");
            }catch(IOException)
            {
                Console.Error.WriteLine("Can't open the file {0}", fileName);
            }

            try
            {
                StreamWriter sw = new StreamWriter("..\\..\\Numbers.txt", true);
                using (sw)
                {
                    sw.WriteLine($"Sum= {firstNum + secondNum}");
                }
            }
            catch (FileNotFoundException)
            {
                Console.Error.WriteLine("Can't find file {0}", fileName);
            }
            catch (DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Invalid Directory in file path");
            }
            catch (IOException)
            {
                Console.Error.WriteLine("Can't open the file {0}", fileName);
            }
        }


    }
}
