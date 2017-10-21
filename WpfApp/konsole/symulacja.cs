using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace konsole
{
    public class Symulacja
    {

        public delegate void OnEventCurrentTimeIsEven(string msg); // tworzymy tym delegata -> funkcja jak ma wyglądać

        public int CounterUser { get; set; }
        public StringBuilder Nazwy { get; private set; }

        private OnEventCurrentTimeIsEven _listOsob; // zmienna prywatna do wyorzystania we właściwościach publicznych
        // tworzymy teraz pole publiczne, które zostaje udostępnione i w nim będziemy zapisywać wszystkie obiekty 
        public event OnEventCurrentTimeIsEven list_osob // właściwości publiczne 
        {
            add
            {
                if (CounterUser <= 100) // jeśli licznik jest <100
                {
                    _listOsob += value;
                }
                CounterUser++; // dodajemy do licznika, jak ktoś się zapisze 

            }
            remove
            {
                _listOsob += value;
            }
        }


        public int CurrentTime;
        
        public Symulacja()
        {
            CurrentTime = 0;

            Nazwy = new StringBuilder();
            string nazwe = string.Empty;
            for (int i = 0; i < 100000000; i++)
            {
                nazwe += i.ToString();
                Nazwy.Append(i.ToString());

            }
            

        }
        public void OdpalSymulacje()
        {
            while (CurrentTime < 10)
            {
                if (CurrentTime % 2 == 0)
                {
                    // Console.WriteLine("Parzysty");
                    RaiseEventOnCurrentTime(CurrentTime.ToString());
                    
                }

                Thread.Sleep(500);

                Console.WriteLine(CurrentTime);
                CurrentTime++;
            }
            

            
        }

        private void RaiseEventOnCurrentTime(string msg)
        {
            if (_listOsob != null) // sprawadzamy czy lista osób jest nullem -> likwidacja wyjątka, gdy nikt się nie zapisał 
            {

                // Console.WriteLine("Parzysty");
                _listOsob(msg); //tutj wywołujemy delegat - zapisana liczba funkcji, które mogą przyjmować msg

                // możemy też to zapisać jako: _listOsob?.Invoke(msg); -> to jest wersja skrócona zapisu -> dostępna po kliknieciu ctrl+. na _listOsob
            }
        }

    }
}
