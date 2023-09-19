namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int result;

            string answer;

            Console.WriteLine("Welcome to the calculator program");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What kind of opertation do you want to do?");
            Console.WriteLine("Please enter a for addition, s for subtraction, d for division, any other button for multiplication.");

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
            else;
            {
                result=num1 * num2;
            }

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Thanks for using my calculator");
            Console.ReadKey();
        }
    }
}