using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp
{
    public class InkCanvasEdMode : INotifyPropertyChanged //implementacja tego interface powoduje, że zmiany wprowadzane pojawiaj a się także na interfejsie graficznym 
    {

        private int _marginCanvas;
        public int MarginCanvas
        {
            get
            {
                return _marginCanvas;
            }

            set
            {
                _marginCanvas = value;
                RaiseEventPropertyChanged("MarginCanvas");

            }
        }

        private InkCanvasEditingMode _editMode;
        public InkCanvasEditingMode EditMode
        {
            get
            {
                return _editMode;
            }

            set
            {
                _editMode = value;
                RaiseEventPropertyChanged("EditMode");
            }
        }
        public InkCanvasEdMode()
        {
            EditMode = InkCanvasEditingMode.Ink;
            MarginCanvas = 10;
        }

        public event PropertyChangedEventHandler PropertyChanged; // event stworzony po to, żeby zapisywał zmiany 

        public void RaiseEventPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        
    }
}
