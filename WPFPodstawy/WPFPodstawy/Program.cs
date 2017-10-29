using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPodstawy;

namespace ReservationEvtents
{
    public static class Program
    {
        static void Main(string[] args)
        {
            EventHandlerReservation eventHandlerReservation = new EventHandlerReservation();

            //tworzymy obiekt rezerwacji 
            // w tym przypadku musi by c +=
            Reservation reservation = new Reservation();
            reservation.ReservationDone += eventHandlerReservation.LogTrans;

            reservation.Reserve("Loki", "Kozo wróć");
            Console.ReadKey();

        }
    }
}
