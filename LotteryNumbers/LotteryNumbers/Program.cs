using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LotteryNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random lottery = new Random();
            char userInput;
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            int[] inOrderLottery = new int[7];

            for (int i = 0; i < 7; i++) 
            {
                inOrderLottery[i] = lottery.Next(1, 37);

            }
            Array.Sort(inOrderLottery);



            do
            {
                Console.WriteLine("\r\nDo you want to buy a lottery ticket? (y/n)");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                
                if (userInput == 'y')
                {
                    for (int i = 0; i < 7; i++)
                    {

                        while(true)
                        {
                            if (sw.ElapsedMilliseconds > 1999)
                            {
                                if (i == 6)
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.Write(inOrderLottery[i] + " ");
                                Console.ResetColor();
                                sw.Restart();
                                break;
                            }
                        }
                    }
                }

                else if (userInput != 'n' && userInput != 'N')
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }


        } while (userInput != 'n' && userInput != 'N');


        }
    }
}
