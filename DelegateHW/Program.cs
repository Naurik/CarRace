using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateHW
{
    class Program
    {
        static void Main(string[] args)
        {
            GameCars games = new GameCars();
            games.ToStartMess();
            games.GoToStartMessage();
            games.Distance(40);

            Console.ReadLine();


        }
    }
    
}
