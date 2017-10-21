using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTemperatureWatcher
{
    class Boss
    {
        private TemperatureWatcher tempwatch;

        public Boss(TemperatureWatcher tempwatch)
        {
            this.tempwatch = tempwatch;
            tempwatch.list_osob += Print;
        }

        public void Print(string msg)
        {
            Console.WriteLine("Temperatura info Boss: " + msg);
        }
    }
}
