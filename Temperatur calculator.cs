namespace Temperatur_translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // here im asking for celsius from the user,
            // and converting it to double. 
            Console.Write("Type out the temperature in Celsius:");
            double celsius = Convert.ToDouble(Console.ReadLine());
            // Here im taking the value i got from the user and calculaturing fahrenheit and the reamur value.
            double fahrenheit = (celsius * 1.8) + 32;
            double reamur = celsius * 0.8;
            // and with these 2 lines im typing out the values i get from the previous calculations.
            Console.WriteLine("Temperature in Fahrenheit:" + fahrenheit + "F");
            Console.WriteLine("Temperature in Reamur:" + reamur + "Re");
        }
    }
}