using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPodstawy
{
    public class EventHandlerReservation
    {
        public void LogTrans(object sender, EventArgs eventArgs)
        {

            //to trzeba napisać, żeby mieć dostęp z args do movie i name 
            var args = eventArgs as ReservationEventArgs;
            Console.WriteLine($"Został ezerwowany bilet na film: {args.Movie}, Użytkownik: {args.Name}");
        }
    }
}
