using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
            ObservableCollection<PersonData> listOfPeople = new ObservableCollection<PersonData>();
        public MainWindow()
        {
            InitializeComponent();
            listOfPeople.Add(new PersonData() { Name = "Anna", Age = 20, Email = "anna@gmail.com" });
            listOfPeople.Add(new PersonData() { Name = "Łukasz", Age = 30, Email = "lukasz198@gmail.com" });
            listOfPeople.Add(new PersonData() { Name = "Krysia", Age = 20, Email = "krysialol@gmail.com" });

            listaImion.ItemsSource = listOfPeople;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            //if (!string.IsNullOrWhiteSpace(NameToAdd.Text)) //to jest funkcja, która wyklucza możliwość wpisywania białych znaków oraz możliwości wstawiania pustych 
            //{
                listOfPeople.Add(new PersonData() { Name = NameToAdd.Text, Age = Convert.ToInt32(AgeToAdd.Text), Email = EmailToAdd.Text });

            //inna wersja:
            //listOfPeople.Add(new PersonData() { Name = NameToAdd.Text, Age = int.TryParse (AgeToAdd.Text, out var num) ? num : 0, Email = EmailToAdd.Text });

        }
    }
    
}
