using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Robot_Factory.Model
{
    public class Robot
    {
        public string task = "";
        public string size = "";
        public byte batteryCapacity;
        public Color color;
        public string chip = "";
        public string wheel = "";

        public Robot(string task, string size,byte batterCapacity, Color color, string chip, string wheel) 
        
        { 
            this.task = task;
            this.size = size;   
            this.batteryCapacity = batterCapacity;  
            this.color = color;
            this.chip = chip;
            this.wheel = wheel;
        }
        
    }

}