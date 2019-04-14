using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public delegate void FinishCar(string message);

    public class SportCar
    {
        public event FinishCar finishS;
        
        public int SportCarSpeed { get; set; }
        public string SportCarType { get; set; }
       
        public void SportCars(int maxSpeed)
        {
            Random rnd = new Random();
            SportCarSpeed = rnd.Next(100, maxSpeed);
            SportCarType = "SportCar";
        }

        public void Finish()
        {
            finishS?.Invoke($"{SportCarType} пришел к финишу первым!!!");
        }


    }
}
