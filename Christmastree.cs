using System;

class Program
{
    static void Main(string[] args)
    {
        // you can change the height of the tree by changing the height number
        int height = 8;
        int spaces = height - 1;
        bool isGreen = false;
        // This for loop runs through the height of the tree
        for (int i = 0; i < height; i++)
        {
            // This loop will write out the leading spaces required for the tree to be resembled
            for (int j = 0; j < spaces; j++)
            {
                Console.Write(" ");
            }
            // this will decide if the stars are either green or red
            for (int j = 0; j < 2 * i + 1; j++)
            {
                if (isGreen)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("*");
                    Console.ResetColor();
                }
                else 
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("*");
                    Console.ResetColor();
                }

                isGreen = !isGreen;
            }

            // decreasing the spaces by 1 for each run
            Console.WriteLine();
            spaces--;
        }
    }
}
