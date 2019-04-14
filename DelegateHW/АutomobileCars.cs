using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public delegate void FinishCarAuto(string message);

    public class АutomobileCar
    {
        public event FinishCarAuto finishA;
        
        public int АutomobileSpeed { get; set; }
        public string АutomobileType { get; set; }

        public void АutomobileCars(int maxSpeed)
        {
            Random rnd = new Random();
            АutomobileSpeed = rnd.Next(40, maxSpeed);
            АutomobileType = "AutoCar";
        }

        public void Finish()
        {
            finishA?.Invoke($"{АutomobileType} пришел к финишу первым!!!");
        }
    }
}
