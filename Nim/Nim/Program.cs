using System.Security.Principal;

namespace Nim
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int totalSticks = 7;
            bool isHumanTurn = true;

            Console.WriteLine("Lets play Nim!");

            while (totalSticks > 0)
            {
                Console.WriteLine("There are" + totalSticks + " Sticks left on the table");
            }

        }
    }
}