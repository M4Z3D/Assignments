using System.Security.Principal;

namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalSticks = 7;
            bool isHumanTurn = true;
            int pickedSticks = 0;

            Console.WriteLine("Lets play Nim!");

            while (totalSticks > 0)
            {
                Console.WriteLine("There are " + totalSticks + " Sticks left on the table");

                int sticksToTake = 0;

                if (isHumanTurn)
                {
                    do
                    {
                        Console.Write("Pick between how many sticks you want to remove (1-3)");
                        int sticksTotake int.Parse(Console.ReadLine());

                    } while (!int.TryParse(Console.ReadLine())); sticksToTake >= totalSticks;
                }
            }

        }
    }
}