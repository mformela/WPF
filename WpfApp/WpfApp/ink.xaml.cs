using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ink.xaml
    /// </summary>
    /// 

    public partial class ink : Window
    {

        private InkCanvasEdMode edit = new InkCanvasEdMode();
        public ink()
        {
            InitializeComponent();
            this.DataContext = edit;
        }

        
        private void x1_Click(object sender, RoutedEventArgs e)
        {
            edit.EditMode = InkCanvasEditingMode.Select;
        }
        private void x2_Click(object sender, RoutedEventArgs e)
        {
            edit.EditMode = InkCanvasEditingMode.Ink;
        }
    }
}
