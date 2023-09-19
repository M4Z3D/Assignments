using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Random random = new Random();
        char userInput;

        do
        {
            Console.WriteLine("Do you want to buy a lottery ticket? (y/n)");
            userInput = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (userInput == 'y' || userInput == 'Y')
            {
                int[] lotteryNumberGenerator = GenerateRandomNumbers(random, 7, 1, 37);

                Console.WriteLine("The lottery numbers are:");

                for (int i = 0; i < lotteryNumberGenerator.Length; i++)
                {
                    if (i == lotteryNumberGenerator.Length - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write(lotteryNumberGenerator[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(lotteryNumberGenerator[i] + " ");
                    }

                    Thread.Sleep(2000); // Delay for 2 seconds
                }
                Console.WriteLine(); // Move to the next line after displaying all numbers
            }
            else if (userInput != 'n' && userInput != 'N')
            {
                Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
            }

        } while (userInput != 'n' && userInput != 'N');
    }

    static int[] GenerateRandomNumbers(Random random, int count, int minValue, int maxValue)
    {
        int[] numbers = new int[count];
        int index = 0;

        while (index < count)
        {
            int randomNumber = random.Next(minValue, maxValue);
            if (Array.IndexOf(numbers, randomNumber) == -1)
            {
                numbers[index] = randomNumber;
                index++;
            }
        }

        return numbers;
    }
}