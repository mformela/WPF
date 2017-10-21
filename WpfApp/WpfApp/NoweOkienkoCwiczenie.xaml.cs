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
    /// Interaction logic for NoweOkienkoCwiczenie.xaml
    /// </summary>
    public partial class NoweOkienkoCwiczenie : Window
    {
        private CheckBoxTester checkBoxTester = new CheckBoxTester();


        public NoweOkienkoCwiczenie()
        {
            InitializeComponent();
            this.DataContext = checkBoxTester;
            CheckBoxStack.DataContext = checkBoxTester;
        }

        private void setTrue_Click(object sender, RoutedEventArgs e)
        {
            checkBoxTester.TestChecked = true;
        }
        private void setFalse_Click(object sender, RoutedEventArgs e)
        {
            checkBoxTester.TestChecked = false;
        }
    }
}
