using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    public delegate void FinishCarLorry(string message);

    public class LorryCar
    {
        public event FinishCarLorry finishL;
        
        public int LorrySpeed { get; set; }
        public string LorryType { get; set; }

        public void LorryCars(int maxSpeed)
        {
            Random rnd = new Random();
            LorrySpeed = rnd.Next(20, maxSpeed);
            LorryType = "LorryCar";
        }

        public void Finish()
        {
            finishL?.Invoke($"{LorryType} пришел к финишу первым!!!");
        }
    }
}
