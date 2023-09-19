using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_jack_again.Model
{
    public class Cards
    {
        int[] cards = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
        Random random = new Random();
        public Cards()
        {


            int randomIndex1 = random.Next(0, cards.Length);
            int randomIndex2;
            int randomIndex3;
            int randomIndex4;

 

            do
            {
                randomIndex2 = random.Next(cards.Length);
                randomIndex3 = random.Next(cards.Length);
                randomIndex4 = random.Next(cards.Length);
            } while (randomIndex2 == randomIndex1);

            int playerHand;
            int randomCard1 = cards[randomIndex1];
            int randomCard2 = cards[randomIndex2];
            int randomCard3 = cards[randomIndex3];
            int randomCard4 = cards[randomIndex4];

    

            Console.WriteLine("Card 1: " + randomCard1);
            Console.WriteLine("Card 2: " + randomCard2);
            Console.WriteLine("Total: " + (randomCard1 + randomCard2));


            Console.WriteLine("'y' for hit 'n' for stay");

            string awaitRespons = Console.ReadLine();
            if (awaitRespons == "y")
            {


                Console.Clear();

                Console.WriteLine("Card 1: " + randomCard1);
                Console.WriteLine("Card 2: " + randomCard2);
                Console.WriteLine("Card 3: " + randomCard3);
                Console.WriteLine("Total: " + (randomCard1 + randomCard2 + randomCard3));

                if (randomCard1+randomCard2 >= 22) 
                {
                    Console.Clear() ;
                    Console.WriteLine("Total: " + (randomCard1 + randomCard2+randomCard3));
                    Console.WriteLine("you are above 21 thus you lose");

                }
                
                

                Console.WriteLine("'y' for hit 'n' for stay");
                string awaitRespons2 = Console.ReadLine();

                if (awaitRespons2 == "y")
                {
                    Console.Clear();

                    Console.WriteLine("Card 1: " + randomCard1);
                    Console.WriteLine("Card 2: " + randomCard2);
                    Console.WriteLine("Card 3: " + randomCard3);
                    Console.WriteLine("Card 4: " + randomCard4);
                    Console.WriteLine("Total: " + (randomCard1 + randomCard2 + randomCard3 + randomCard4));
                }
                else if (randomCard1 + randomCard2 + randomCard3 + randomCard4 >= 22)
                {
                    Console.Clear();
                    Console.WriteLine("Total: " + (randomCard1 + randomCard2 + randomCard3 + randomCard4));
                    Console.WriteLine("you are above 21 thus you lose");
                }
                else
                {
                    Console.WriteLine("You are staying");
                }
            

            }

        }
    }
}
