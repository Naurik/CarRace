using System;

namespace DelegateHW
{
    public delegate void Game(string message);

    public class GameCars : Car
    {
        SportCar sport = new SportCar();
        АutomobileCar auto = new АutomobileCar();
        BusCar bus = new BusCar();
        LorryCar lorry = new LorryCar();

        Game distanceCar = Message;
        Game goToSatrt = Message;
        Game toStart = Message;
        public void ToStartMess()
        {
            toStart?.Invoke("К старту!");
        }
        public void GoToStartMessage()
        {
            goToSatrt?.Invoke("Начать гонку!!!");
        }

        public void Distance(int distance)
        {
            Random rnd = new Random();
            while (distance <= 100)
            {
                sport.SportCars(rnd.Next(200,400));
                lorry.LorryCars(rnd.Next(150, 350));
                auto.АutomobileCars(rnd.Next(250, 300));
                bus.BusCars(rnd.Next(90, 100));
                
                int ds = sport.SportCarSpeed;//СпортКар скорость
                int dl = lorry.LorrySpeed;//Грузовая скорость
                int da = auto.АutomobileSpeed;//Легковая скорость
                int db = bus.BusSpeed;//Автобус скорость
                if (ds > dl && ds > da && ds > da)
                {
                    distanceCar?.Invoke($"На {distance} м финиширует {sport.SportCarType} -- Скорость {ds}");
                    if (distance == 100)
                    {
                        sport.Finish();
                    }
                }
                if (dl > ds && dl > da && dl > da)
                {
                    distanceCar?.Invoke($"На {distance} м финиширует {lorry.LorryType} -- Скорость {dl}");
                    if (distance == 100)
                    {
                        lorry.Finish();
                    }
                }
                if (db > ds && db > da && db > dl)
                {
                    distanceCar?.Invoke($"На {distance} м финиширует {bus.BusType} -- Скорость {db}");
                    if (distance == 100)
                    {
                        bus.Finish();
                    }
                }
                if (da > ds && da > dl && da > db)
                {
                    distanceCar?.Invoke($"На {distance} м финиширует {auto.АutomobileType} -- Скорость {da}");
                    if (distance == 100)
                    {
                        auto.Finish();
                    }
                }
                distance += 10;
                sport.SportCars(400);
                lorry.LorryCars(200);
                auto.АutomobileCars(300);
                bus.BusCars(100);
            }
        }

        public static void Message(string mess)
        {
            Console.WriteLine(mess);
        }
    }
    
}
