using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public delegate void FinishCarBus(string message); 

    public class BusCar
    {
        public event FinishCarBus finishB;
        
        public int BusSpeed { get; set; }
        public string BusType { get; set; }

        public void BusCars(int maxSpeed)
        {
            Random rnd = new Random();
            BusSpeed = rnd.Next(10, maxSpeed);
            BusType = "BusCar";
        }

        public void Finish()
        {
            finishB?.Invoke($"{BusType} пришел к финишу первым!!!");
        }
    }
}
