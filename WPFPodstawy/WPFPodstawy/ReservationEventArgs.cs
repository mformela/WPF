using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPodstawy
{

    //customowa klasa która bédzie nam dawaøa dodatkowe dane
    public class ReservationEventArgs : EventArgs
    {
        public string ReservationID { get; private set; }
        public  string Name { get; private set; }
        public string Movie { get; private set; }



        // Tworzymy konstruktor 
        //guid -> statyczna metoda, ktora inicjalizuje instancje ze struktury Guid
        public ReservationEventArgs(string name, string movie)
        {
            this.ReservationID = System.Guid.NewGuid().ToString();
            this.Name = name;
            this.Movie = movie;
        }
    }
}
