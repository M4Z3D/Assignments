using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_adventure
{

    public class RemoteControlCar
    {
        private int _batteryCapacity;
        private int _drivenMeters;
        private string color;
        public RemoteControlCar(string color)
        {
            this.color = color;
            _batteryCapacity = 100;
            _drivenMeters = 0;
        }
        public void Drive()
        {
            if (_batteryCapacity > 0)
            {
                _drivenMeters += 20;
                _batteryCapacity -= 1;
            }
            else
            {
                Console.WriteLine($"The battery of the {color} car is empty. Please recharge the car.");
            }
        }
        public void Recharge()
        {
            _batteryCapacity = 100;
            _drivenMeters = 0;
            Console.WriteLine($"The {color} car is recharged.");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Car color: {color}");
            Console.WriteLine($"Number of driven meters: {_drivenMeters}");
            Console.WriteLine($"Battery life: {_batteryCapacity}%");
        }
        public string GetColor()
        {
            return color;
        }

        public int GetBatteryCapacity()
        {
            return _batteryCapacity;
        }
    }
}
