using System.Drawing;
using System.Reflection;
using Elon_Musk.DAL;
using Elon_Musk.Logic;

namespace Elon_Musk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates an instance of the eletric car class
            ElectricCar electricCar1 = new ElectricCar()
            {
                Model = "Cybertruck",
                Color = Color.DarkRed,
                Battery = 100,
                MetersDriven = 0,


            };
            // creates an instance of the eletric car class
            ElectricCar electricCar2 = new ElectricCar()
            {
                Model = "Model 3",
                Color = Color.DarkBlue,
                Battery = 100,
                MetersDriven = 0,

            };
            // Create a controller for the first electric car
            ElectricCarController controller = new ElectricCarController(electricCar1);

            // look past this
            // electricCar1.Drive();
            // electricCar2.Drive();
            // electricCar1.Status();
            // electricCar2.Status();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Drive");
                Console.WriteLine("2. Status");
                Console.WriteLine("3. Exit");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    // Tells the controller to drive the eletric car
                    case "1":
                        controller.Drive();
                        break;
                    // Tells the controller to give a status of the eletric car
                    case "2":
                        controller.Status();
                        break;
                    // Exits the program
                    case "3":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}

