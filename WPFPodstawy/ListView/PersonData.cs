using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListView
{
    class PersonData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public static ObservableCollection<string> ItemsSource { get; internal set; }
    }
    
}
