namespace Rumfang_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //here im asking the user for the different measurements of the different things like height, width and length
            Console.WriteLine("I will help you calculate the volume");
            Console.Write("Type the height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type the width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Type the length:");
            double length = Convert.ToDouble(Console.ReadLine());
            // and here we are taking those values we asked the user for and then calculating them, and typing out a sentence telling them that the volume is
            Console.WriteLine("The volume of the object is:"+ height*width*length);

        }
    }
}