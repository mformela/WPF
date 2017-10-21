using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Symulacja symulacja = new Symulacja();
            //tworzymy instancje klas dla Pracownika i Szefa
            Pracownik pracownik = GetPracownik(symulacja);
            Szef szef = GetSzef(symulacja);

            symulacja.OdpalSymulacje();

            Console.ReadKey();
        }

        private static Szef GetSzef(Symulacja symulacja)
        {
            return new Szef(symulacja);
        }

        private static Pracownik GetPracownik(Symulacja symulacja)
        {
            return new Pracownik(symulacja);
        }
    }
}
