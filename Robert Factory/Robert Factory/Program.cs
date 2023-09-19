using Robot_Factory.Model;
using System.Drawing;

namespace Robert_Factory
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Robot robot1 = new Robot("Sweeper", " Small", 255, Color.White, " Default", " Has wheels");
            Robot robot2 = new Robot("window Cleaner", " Big", 255, Color.Blue, " RX54667", " No Wheels");
            Robot robot3 = new Robot("Tire Changer", " Big", 255, Color.Green, " QT8339", " No Wheels");

            WriteToGUI(robot1, robot2, robot3);
        }
        private static void WriteToGUI(Robot robot1, Robot robot2, Robot robot3)
        {
            Console.WriteLine("robot 1");
            Console.WriteLine($"task:{robot1.task}");
            Console.WriteLine($"size:{robot1.size}");
            Console.WriteLine($"Battery:{robot1.batteryCapacity}");
            Console.WriteLine($"Color:{robot1.color}");
            Console.WriteLine($"Chip:{robot1.chip}");
            Console.WriteLine($"wheels:{robot1.wheel}");
            Console.WriteLine();

            Console.WriteLine("robot 2");
            Console.WriteLine($"task:{robot2.task}");
            Console.WriteLine($"size:{robot2.size}");
            Console.WriteLine($"Battery:{robot2.batteryCapacity}");
            Console.WriteLine($"Color:{robot2.color}");
            Console.WriteLine($"Chip:{robot2.chip}");
            Console.WriteLine($"wheels:{robot2.wheel}");
            Console.WriteLine();

            Console.WriteLine("robot 3");
            Console.WriteLine($"task:{robot3.task}");
            Console.WriteLine($"size:{robot3.size}");
            Console.WriteLine($"Battery:{robot3.batteryCapacity}");
            Console.WriteLine($"Color:{robot3.color}");
            Console.WriteLine($"Chip:{robot3.chip}");
            Console.WriteLine($"wheels:{robot3.wheel}");
            Console.ReadLine();
        }
    }
}
 