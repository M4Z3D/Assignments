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
            // Creating a variable with random values so i can input them in the array later on
            Random lottery = new Random();
            // Awaiting user input so we can either start the loop or exit
            char userInput;
            // Creating a stop watch so i can make a delay between the numbers getting announched
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            // Creating an array that takes the random numbers and sorting them by lowest to highest
            int[] inOrderLottery = new int[7];

            for (int i = 0; i < 7; i++) 
            {
                inOrderLottery[i] = lottery.Next(1, 37);

            }
            Array.Sort(inOrderLottery);


            // Making a do-while loop that prompts the user to with a choice to buy a ticket
            do
            {
                Console.WriteLine("\r\nDo you want to buy a lottery ticket? (y/n)");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();
                // this if statement reads if the users input and deciding if they type y this forloop will run
                if (userInput == 'y')
                {
                    for (int i = 0; i < 7; i++)
                    {
                        // This while loop will both take use of the StopWatch 
                        while(true)
                        {
                            if (sw.ElapsedMilliseconds > 1999)
                            {
                                // This is coloring the last one and writes the lottery numbers in order and resets the stopwatch
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
                // If the users inputs anything else than n or y they will be promted with this messages
                else if (userInput != 'n' && userInput != 'N')
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                }

        // When the users inputs n or N they will exit the loop and close the console
        } while (userInput != 'n' && userInput != 'N');


        }
    }
}
