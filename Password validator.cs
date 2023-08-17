using System.ComponentModel.Design;
using System.Linq;

namespace Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("    ____                 _       __               __   _    __      ___     __      __            ");
            Console.WriteLine("   / __ \\____ __________| |     / /___  _________/ /  | |  / /___ _/ (_)___/ /___ _/ /_____  _____");
            Console.WriteLine("  / /_/ / __ `/ ___/ ___/ | /| / / __ \\/ ___/ __  /   | | / / __ `/ / / __  / __ `/ __/ __ \\/ ___/");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(" / ____/ /_/ (__  |__  )| |/ |/ / /_/ / /  / /_/ /    | |/ / /_/ / / / /_/ / /_/ / /_/ /_/ / /    ");
            Console.WriteLine("/_/    \\__,_/____/____/ |__/|__/\\____/_/   \\__,_/     |___/\\__,_/_/_/\\__,_/\\__,_/\\__/\\____/_/     ");
            Console.ResetColor();




            Console.WriteLine("\nThere is some requirements that have to be met for a perfect score.");
            Console.WriteLine("1. password must be a minimum of 12 characters and a maximum of 64.");
            Console.WriteLine("2. It must include a mix of both UPPER and lowercase letters.");
            Console.WriteLine("3. It must include a mix of characters and numbers. And must include at least one special character.");
            Console.Write("\nType your password to be validated:");







            String password = Console.ReadLine();

            int numbersOfCharacters = password.Length;

            if (numbersOfCharacters < 12)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your password is less than 12 characters");
                Console.ResetColor();
                
            }
            else if (numbersOfCharacters > 64)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Your password is too long exceeds 64 characters");
                Console.ResetColor();
            }

            else
            {
                bool hasUpperCase = password.Any(char.IsUpper);
                bool hasLowerCase = password.Any(char.IsLower);
                bool hasSpecialCharacters = password.Any(p => !char.IsLetterOrDigit(p));



                if (!hasUpperCase || !hasLowerCase)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your password does not contain both upper and lower cases");
                    Console.ResetColor();
                }


                else if (!hasSpecialCharacters)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your password does not contain at least 1 special character");
                    Console.ResetColor();
                }


                else if (hasSpecialCharacters)
                {
                    string badNumbersR1 = "1234567890";
                    string badLettersR2 = "qwertyuiop";
                    string badLettersR3 = "asdfghjkl";
                    string badLettersR4 = "zxcvbnm";
                    bool containsConsequtive = false;

                    for (int i = 0; i < password.Length - 3; i++)
                    {
                        if (badNumbersR1.Contains(password.Substring(i, 4)) ||
                            badLettersR2.Contains(password.Substring(i, 4)) ||
                            badLettersR3.Contains(password.Substring(i, 4)) ||
                            badLettersR4.Contains(password.Substring(i, 3)))
                        {
                            containsConsequtive = true;
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("password contains 3 consecutive letters or numbers");
                            Console.WriteLine("It passes but will be considered weak");
                            Console.ResetColor();
                            break;
                        }
                    }
                  if (!containsConsequtive) 
                    
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Your password is passed");
                        Console.WriteLine("Its considered strong because of requirements and no consecutive patterns");
                        Console.ResetColor();

                    }
                }




            }

            Console.WriteLine("Your password is: " + password);
            Console.WriteLine("Password length: " + numbersOfCharacters);
        }
    }
}