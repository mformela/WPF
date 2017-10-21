using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsole
{
    class Pracownik
    {
        private Symulacja symulacja;

        public Pracownik(Symulacja symulacja)
        {
            this.symulacja = symulacja;
            symulacja.list_osob += Print;
        }

        public void Print(string message)
        {
            Console.Write("Pracownik: " + message);
        }
    }
}
