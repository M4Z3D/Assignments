using Elon_Musk.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elon_Musk.Logic
{
    /// <summary>
    /// Controller for managing electric cars.
    /// </summary>
    public class ElectricCarController
    {
        private ElectricCar _model;

        public ElectricCarController(ElectricCar model)
        {
            _model = model;
        }
        // It gives the drive action to the associated eletric car model
        public void Drive()
        {
            _model.Drive();
        }
        // This method retrives the status of the associated eletric car model
        public void Status()
        {
            _model.Status();
        }
    }
}