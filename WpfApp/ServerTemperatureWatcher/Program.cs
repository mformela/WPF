using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTemperatureWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureWatcher tempwatch = new TemperatureWatcher();
            //tworzymy instancje klas dla Pracownika i Szefa
            Boss boss = new Boss (tempwatch);
            Admin admin = new Admin (tempwatch);

            tempwatch.OdpalTemperatureWatcher();

            Console.ReadKey();
        }

        

        
    }
}
