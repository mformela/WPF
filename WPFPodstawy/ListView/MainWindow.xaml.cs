using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
            
            listOfPeople.Add(new PersonData() { Name = "Łukasz", Age = 30, Email = "lukasz198@gmail.com" });
            listOfPeople.Add(new PersonData() { Name = "Krysia", Age = 26, Email = "krysialol@gmail.com" });
            listOfPeople.Add(new PersonData() { Name = "Krysia", Age = 24, Email = "krysialol@gmail.com" });
            listOfPeople.Add(new PersonData() { Name = "Anna", Age = 20, Email = "anna@gmail.com" });
            listOfPeople.Add(new PersonData() { Name = "Warol", Age = 20, Email = "karol@wp.pl" });
            listOfPeople.Add(new PersonData() { Name = "Aneta", Age = 200, Email = "maciek@wp.pl" });
            listOfPeople.Add(new PersonData() { Name = "Marta", Age = 25, Email = "marta@wp.pl" });

            listaImion.ItemsSource = listOfPeople;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                listOfPeople.Add(new PersonData() { Name = NameToAdd.Text, Age = Convert.ToInt32(AgeToAdd.Text), Email = Regex.IsMatch(EmailToAdd.Text, pattern) ? EmailToAdd.Text : string.Empty });
          
                //inna wersja:
               // listOfPeople.Add(new PersonData() { Name = NameToAdd.Text, Age = int.TryParse (AgeToAdd.Text, out var num) ? num : 0, Email = EmailToAdd.Text });
        }



        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            
            // zmienione, żeby móc usuwać wybrane rzeczy z listy (nie po indexie jak poprzednio, tylko według zaznaczenia)
            var selectedItem = (PersonData)listaImion.SelectedItem;
            if (selectedItem != null)
            {
                listOfPeople.Remove(selectedItem);
            }
        }

        private void GridViewColumnHeader_Click(object sender, RoutedEventArgs e)
        {
            GridViewColumnHeader header = (sender as GridViewColumnHeader);
            string columnNameToSort = header.Content.ToString();

            //if (header != null)
            //{
            //    columnNameToSort = header.Content.ToString();
            //}


            var howToSort = ListSortDirection.Ascending;


            // to spina nam to całe sortowanie. pobieramy sobie widok listy imion
            // (CollectionView) -> wymuszamy - nie robi to automatycznie, robimy tutaj konwersję 
            // inny zapis: CollectionView view = CollectionViewSource.GetDefaultView(listaImion.ItemsSource) as CollectionView;
            CollectionView view = (CollectionView) CollectionViewSource.GetDefaultView(listaImion.ItemsSource);

            //jeśli kliknę raz to sortuje w jedną stronę, a jeśli drugi raz to posortuje w odwrotny sposób
            if(view.SortDescriptions.Any())
            {
                SortDescription item = view.SortDescriptions.ElementAt(0); // pobieramy elementy 
                if(columnNameToSort == item.PropertyName.ToString())
                    {
                        if(item.Direction == ListSortDirection.Ascending)
                            {
                                howToSort = ListSortDirection.Descending;
                            }
                        else
                            {
                                howToSort = ListSortDirection.Ascending;
                            }

                    }
            }


            
            view.SortDescriptions.Clear(); // to umożliwia nam sortowanie -> czyści nam za każdym razem
                                           //jeśli zostawimy clear to nie zostawia nam posortowanej pierwszej kolumny - resetuje sortowanie 
                                           // jeśli usuniemy clear to sortuje nam jedną kolumnę a do niej sortuje drugą, tak że sortowanie z pierwszej pozostaje aktywne 
            view.SortDescriptions.Add(new SortDescription(columnNameToSort, howToSort));
            // 0 oznacza rosnący, 1 malejący można to zamiast ListSortDirection
            //view.SortDescriptions.Add(new SortDescription(columnNameToSort, 0));
        }

        private void listaImion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    
}
