using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_Musk.DAL
{
    /// <summary>
    /// This Class models an eletric car(s) attributes and actions includes battery levels and color
    /// </summary>
    public class ElectricCar
    {
        private string _model = "";
        private Color _color;
        private byte _battery;
        private int _metersDriven;
        private bool _chargeBattery;
        private bool _driveCar;


        // returns model of eletric car.
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        // returns color of eletric car.
        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }
        // returns battery level of eletric car.
        public byte Battery
        {
            get { return _battery; }
            set { _battery = value; }
        }
        // returns meters driven of eletric car.
        public int MetersDriven
        {
            get { return _metersDriven; }
            set { _metersDriven = value; }
        }
        // returns car drove value.
        public bool DriveCar
        {
            get { return _driveCar; }
            set { _driveCar = value; }
        }
        // Write out the status of the car in the GUI.
        public void Status()
        {
            Console.WriteLine($" {Model} has the {Color} and is at {Battery}% battery the car has driven {MetersDriven} meters");
        }

        // Write out the drive the car made in the GUI including the battery procentage.
        public void Drive()
        {
            while (Battery > 0)
            {
                _driveCar = true;
                if (Battery > 0)
                {
                    MetersDriven += 20;

                    Battery -= 1;
                    Thread.Sleep(100);
                    
                    Status();
                }
                else
                {
                    Console.WriteLine($"The battery of the car is empty. Please recharge the car.");
                }

            }    
        }
    }

}