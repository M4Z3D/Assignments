using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        char userInput;

        do
        {
            Console.WriteLine("Do you want to pick random numbers? (y/n)");
            userInput = Console.ReadKey().KeyChar; // Corrected variable type to char
            Console.WriteLine();

            if (userInput == 'y' || userInput == 'Y')
            {
                int[] randomNumbers = GenerateRandomNumbers(random, 7, 1, 37);

                Console.WriteLine("Random Numbers:");
                foreach (int num in randomNumbers)
                {
                    Console.WriteLine(num);
                }
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