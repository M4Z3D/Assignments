using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Hello and welcome to my little program of different projects");
            Console.WriteLine("Type c for the calculator");
            Console.WriteLine("Type d for the dice");
            Console.WriteLine("type g for the number guessing game");
            Console.WriteLine("type p for the player vs computer fighting game");


            string? Choice;
            Choice = Console.ReadLine();

            Console.WriteLine(Choice);
            switch (Choice)
            {
                case ("c"):
                    Console.Clear();
                    Calculator();
                    Main(new string[0]);
                    break;

                case ("d"):
                    Console.Clear();
                    Dice();
                    Main(new string[0]);
                    break;

                case ("g"):
                    Console.Clear();
                    GuessingGame();
                    Main(new string[0]);
                    break;

                case ("p"):
                    Console.Clear();
                    PvE();
                    Main(new string[0]);
                    break;

            }

        }
        static void Calculator()
        {
            int num1;
            int num2;
            int result;

            string? answer;

            Console.WriteLine("Welcome to the calculator program");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What kind of opertation do you want to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, d for division, any other letter for multiplication.");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num2 + num1;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }

            else if (answer == "d")
            {
                result = num1 / num2;
            }
            else
            {
                result = num1 * num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thanks for using my calculator");

            Console.ReadLine();

        }


        static void Dice()
        {
            int amountOfRolls;
            int amountOfEyes;

            Console.WriteLine("Welcome to the dice program");
            Console.WriteLine("What Dice do you want to roll?");
            Console.WriteLine("Enter 'a' for a 6-sided dice, 'b' for an 18-sided dice, or 'c' for a 100-sided dice");
            string? dice = Console.ReadLine();

            if (dice == "a")
            {
                amountOfEyes = 6;
            }

            else if (dice == "b")
            {
                amountOfEyes = 18;
            }

            else if (dice == "c")
            {
                amountOfEyes = 100;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'a', 'b', or 'c'.");
                return;
            }


            Console.WriteLine("How many times to do you want the dice to be rolled");
            amountOfRolls = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < amountOfRolls; i++)
            {
                int num = rnd.Next(1, amountOfEyes + 1);
                Console.WriteLine("You rolled " + num);
                Thread.Sleep(100);
            }
            Console.ReadLine();









        }

        static void GuessingGame()
        {
            bool isCorrectGuess = false;
            Random random = new Random();

            int randomNumber = random.Next(1, 11);


            Console.WriteLine("Welcome to the number guessing game");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("if you guess the correct number, you win!");

            //Console.WriteLine(randomNumber);
            while (!isCorrectGuess)
            {
                Console.WriteLine("Please enter your guess");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    Console.ReadLine();
                    isCorrectGuess = true;


                }
            }

        }
        public class Fighter
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Fighter(int iD, string name)
            {
                ID = iD;
                Name = name;
            }
        }
        static void PvE()
        {

            Console.WriteLine("Welcome to the battle ground!");
            Console.WriteLine("Ready to play? press 'y' for yes 'n' for no");
            string? userInput = Console.ReadLine();
            if (userInput == "y")
            {
                Console.Clear();

                int playerHP = 30;
                int enemyHP = 20;

                int playerAttack = 5;
                int enemyAttack = 7;

                int healAmount = 5;

                Console.WriteLine("The arena is open!");
                Console.Write("Your opponent is");

                Fighter[] fighters = new Fighter[5];

                fighters[0] = new Fighter(1, "Eldon Shadowwalker");
                fighters[1] = new Fighter(2, "Crimson Payne");
                fighters[2] = new Fighter(3, "Vayne Addington");
                fighters[3] = new Fighter(4, "Harlot Umbra");
                fighters[4] = new Fighter(5, "Grendel Winter");

                Random random = new Random();
                int randomIndex = random.Next(0, fighters.Length);

                Fighter randomFighter = fighters[randomIndex];

                Console.WriteLine(" " + randomFighter.Name);


                while (playerHP > 0 && enemyHP > 0)
                {
                    // Player turn
                    Console.WriteLine("-- Player turn --");
                    Console.WriteLine("Player Health - " + playerHP + " Enemy health " + enemyHP);
                    Console.WriteLine("Enter 'a' To attack or 'h' to heal");

                    string? choice = Console.ReadLine();

                    if (choice == "a")
                    {
                        enemyHP -= playerAttack;
                        Console.WriteLine("You attacked " + randomFighter.Name + " and dealt " + playerAttack + " damage!");
                    }
                    else
                    {
                        playerHP += healAmount;
                        Console.WriteLine("You have healed yourself " + healAmount + " health");
                    }
                    if (enemyHP <= 0)
                    {
                        Console.WriteLine("You have Won!");
                        Console.ReadLine();
                        break; // Exit the loop, the game is over
                    }


                    // Enemy turn

                    if (enemyHP > 0)
                    {
                        Console.WriteLine("Its now " + randomFighter.Name + " Turn!");
                        int enemyChoice = random.Next(0, 2);



                        if (enemyChoice == 0)
                        {
                            playerHP -= enemyAttack;
                            Console.WriteLine("The enemy " + randomFighter.Name + " dealt " + enemyAttack + " Damage!");
                        }
                        else
                        {
                            enemyHP += healAmount;
                            Console.WriteLine("The enemy " + randomFighter.Name + " heals " + healAmount + " health");
                        }
                        // Check if the game has ended after the enemy's turn
                        if (playerHP <= 0)
                        {
                            Console.WriteLine("You have lost");
                            Console.ReadLine();
                            break; // Exit the loop, the game is over
                        }
                    }

                }

            }

        }
    }

}