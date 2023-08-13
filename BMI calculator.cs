namespace Bmi_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //askinf for the users information Height/weight
            Console.WriteLine("Let's calculate your BMI");
           
            Console.Write("Type your Height in centimeters:");

            // Converting the input to the double datatype
            double HeightInCM = double.Parse(Console.ReadLine());
            double HeightInM = (HeightInCM / 100);

            // Converting the input to the double datatype
            Console.Write("Type out your weight in kilograms:");
            double WeightInKG=double.Parse(Console.ReadLine());
            //Taking the 2 values ive gathered and then calculating the BMI and saving it in the varible "number"
           double Number=(WeightInKG/(HeightInM*HeightInM));
            // Since the double Datatype is very precise with alot of decimals im then rounding the numbers to only have 1 decimal 
            double BMI = Math.Round(Number,1);



            // This is my while true loop that is checking what spand the BMI is being put into with the different groups of weightclasses
            while(true)
            {
                //if bmi is greater than or qeual then you will be promted with this message
                if (BMI >= 40)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Your BMI is the group of obesity third degree");
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                //if bmi is greater than or qeual then you will be promted with this message
                else if (BMI >= 35)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your BMI is the group of obesity second degree");
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                //if bmi is greater than or qeual then you will be promted with this message
                else if (BMI >= 30)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("Your BMI is the group of obesity first degree");
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                //if bmi is greater than or qeual then you will be promted with this message
                else if (BMI >= 24)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Your BMI is the group of overweight");
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                //if bmi is greater than or qeual then you will be promted with this message
                else if (BMI >= 18.5)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your BMI is the group of the norm");
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                //if bmi is greater than or qeual then you will be promted with this message
                else _ = (BMI >= 16);
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your BMI is the group of body weight deficit");
                    Console.WriteLine("Your BMI is " + BMI);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }
    }
}