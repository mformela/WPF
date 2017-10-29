using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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


        //jak zrobić regex na maila
        string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";


            // inna wersja regexa na maila
        //public bool IsValid(string emailaddress)
        //{
        //    try
        //    {
        //        MailAddress m = new MailAddress(emailaddress);

        //        return true;
        //    }
        //    catch (FormatException)
        //    {
        //        return false;
        //    }
        //}




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

            
                listOfPeople.Add(new PersonData() { Name = NameToAdd.Text, Age = Convert.ToInt32(AgeToAdd.Text), Email = Regex.IsMatch(EmailToAdd.Text, pattern) ? EmailToAdd.Text : string.Empty });
          

                //inna wersja:
               // listOfPeople.Add(new PersonData() { Name = NameToAdd.Text, Age = int.TryParse (AgeToAdd.Text, out var num) ? num : 0, Email = EmailToAdd.Text });
            
        }
    }
    
}
