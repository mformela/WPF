using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ResourcesWPF
{
    class ValueContent : INotifyPropertyChanged 
    {
        public Visibility Vi { get; set; }
        

        private Brush _color;

        public Brush ColorRec
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ColorRec"));
            }
        }

        public ValueContent()
        {
            Vi = Visibility.Collapsed;
            ColorRec = Brushes.DarkCyan;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        
    }
}
