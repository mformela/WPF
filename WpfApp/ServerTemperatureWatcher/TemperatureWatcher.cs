using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerTemperatureWatcher
{
    class TemperatureWatcher
    {
        public delegate void OnEventCurrentTemperatureIsEven(string msg); // tworzymy tym delegata -> funkcja jak ma wyglądać

        
      
    
        private OnEventCurrentTemperatureIsEven _temperatura; // zmienna prywatna do wyorzystania we właściwościach publicznych
        // tworzymy teraz pole publiczne, które zostaje udostępnione i w nim będziemy zapisywać wszystkie obiekty 
        public event OnEventCurrentTemperatureIsEven list_osob // właściwości publiczne 
        {
            add
            {
                if (CounterTemperature <= 100) // jeśli licznik jest <100
                {
                    _temperatura += value;
                }
                CounterTemperature++; // dodajemy do licznika, jak ktoś się zapisze 

            }
            remove
            {
                _temperatura += value;
            }
        }



        public int CurrentTemperature;

        public int CounterTemperature { get; private set; }

        //public void TemperatureWatcherCheck()


        //{

        //    Random rnd = new Random();
        //    while (CurrentTemperature <= 80)

        //    {

        //        CurrentTemperature = rnd.Next(60, 100);
        //        Console.WriteLine("Server temperature is: " + CurrentTemperature.ToString());

        //        if (CurrentTemperature > 80)

        //        {
        //            RaiseEventOnCurrentTemperature(CurrentTemperature);

        //        }

        //    }


        //}

        //private void RaiseEventOnCurrentTemperature(int currentTemperature)
        //{
        //    throw new NotImplementedException();
        //}

        public void OdpalTemperatureWatcher()

        {

            Random rnd = new Random();
            while (CurrentTemperature <= 80)

            {

                CurrentTemperature = rnd.Next(60, 100);
                Console.WriteLine("Temperatura serwera wynosi: " + CurrentTemperature.ToString());

                if (CurrentTemperature > 80)

                {
                    RaiseEventOnCurrentTemperature(CurrentTemperature);
                    Console.WriteLine("Temperatura za wysoka!!!");
                }

            }

        }

        //{
        //    while (CurrentTemperature < 100)
        //    {
        //        if (CurrentTemperature > 80)
        //        {
        //            Console.WriteLine("Tempetratura za wysoka!!!");
        //            //RaiseEventOnCurrentTemperature(CurrentTemperature.ToString());

        //        }

        //        Thread.Sleep(500);

        //        Console.WriteLine(CurrentTemperature);
        //        CurrentTemperature++;
        //    }



        }

        private void RaiseEventOnCurrentTemperature(string msg)
        {
                _temperatura?.Invoke(msg); 
        }

    }
}

