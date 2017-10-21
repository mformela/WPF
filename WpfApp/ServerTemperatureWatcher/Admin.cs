using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTemperatureWatcher
{
    class Admin
    {
        private TemperatureWatcher tempwatch;

        public Admin(TemperatureWatcher tempwatch)
        {
            this.tempwatch = tempwatch;
            tempwatch.list_osob += Print;
        }

        public void Print(string message)
        {
            Console.Write("temperatura info Admin: " + message);
        }
    }
}
