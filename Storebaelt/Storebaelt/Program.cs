namespace Storebaelt
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Calculating the amount of trafic on the bridge");
            Console.WriteLine("How many motorcycle have crossed?");
            int Motorcycle = int.Parse(Console.ReadLine());


            Console.WriteLine("How many cars have crossed?");
            int Cars = int.Parse(Console.ReadLine());

            Console.WriteLine("How many trucks and busses have crossed?");
            int Trucks = int.Parse(Console.ReadLine());

            int calculatedAmountOfWheels = ((Motorcycle * 2) + (Cars * 4) + (Trucks * 6));

            Console.WriteLine(calculatedAmountOfWheels+" Wheels have crossed the bridge"); 
        }
    }
}