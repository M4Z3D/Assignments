using System.ComponentModel.Design;

namespace Terningen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Roll the dice!");
            // assigin the varible "random" a random class to spit out a random number
            Random random = new Random();

            // its awaiting a signal from the while statement further down if it needs to do the sequence again. aka a loop
            do
            {
                // giving  the varible "dice" a random value from 1-7 and from 1 to 7 there is 6 different outcomes
                int dice = random.Next(1, 7);


                // At this else if statement is true im deciding that im changing the text color to yellow
                if (dice == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("You have rolled a one!");
                }
                // At this else if statement is true im deciding that im changing the text color to green
                else if (dice == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have rolled a two!");
                }
                // At this else if statement is true im deciding that im changing the text color to red
                else if (dice == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have rolled a three!");
                }
                // At this else if statement is true im deciding that im changing the text color to cyan
                else if (dice == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("You have rolled a four!");
                }
                // At this else if statement is true im deciding that im changing the text color to dark magenta
                else if (dice == 5)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("You have rolled a five!");
                }
                // At this else if statement is true im deciding that im changing the text color to dark blue
                else if (dice == 6)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("You have rolled a six!");

                }
                // asking the user if they want to roll again? and by them inputting y it will re roll
                Console.WriteLine("Roll again? (y/n)");
            } while (Console.ReadLine().ToLower() == "y");

        }
    }
}