using Black_jack.Model;

namespace Black_jack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opret et array med kort
            Card[] deck = InitializeDeck();
            ShuffleDeck(deck);

            // Del kort til spilleren og dealeren
            Card[] playerHand = new Card[2];
            Card[] dealerHand = new Card[2];

            for (int i = 0; i < 2; i++)
            {
                playerHand[i] = deck[i];
                dealerHand[i] = deck[i + 2];
            }

            // Vis spillerens kort
            Console.WriteLine("Spillerens kort:");
            foreach (var card in playerHand)
            {
                Console.WriteLine(card);
            }

            // Vis dealeren første kort
            Console.WriteLine("\nDealens kort:");
            Console.WriteLine(dealerHand[0]);

            // Implementer resten af spillogikken her

        }

        // Initialiser et standard kortspil
        static Card[] InitializeDeck()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] faceValues = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            Card[] deck = new Card[suits.Length * faceValues.Length];
            int index = 0;

            foreach (var suit in suits)
            {
                foreach (var faceValue in faceValues)
                {
                    deck[index] = new Card { Suit = suit, FaceValue = faceValue };
                    index++;
                }
            }

            return deck;
        }

        // Bland kortene i kortspillet
        static void ShuffleDeck(Card[] deck)
        {
            Random random = new Random();

            for (int i = deck.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);
                Card temp = deck[i];
                deck[i] = deck[j];
                deck[j] = temp;
            }
        }
    }
}