﻿using System;
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

namespace ComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ObservableCollection<string> listOfNames = new ObservableCollection<string>();
        public MainWindow()
        {
            InitializeComponent();
            listOfNames.Add("Loki");
            listOfNames.Add("Maciek");
            listOfNames.Add("Marta");


            ListaImion.ItemsSource = listOfNames;


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NameToAdd.Text)) //to jest funkcja, która wyklucza możliwość wpisywania białych znaków oraz możliwości wstawiania pustych 
            {
                listOfNames.Add(NameToAdd.Text.Trim());
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //tutaj tworzymy metodę, która będzie nam usuwac elementy/obiekty na podstawie indexu
            int selectedNameIndex = ListaImion.SelectedIndex;
            if (selectedNameIndex != -1)
            {
                listOfNames.RemoveAt(selectedNameIndex);
            }
        }
    }
}
