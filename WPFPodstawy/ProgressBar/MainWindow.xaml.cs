using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
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


namespace ProgressBar
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WebClient webClient;

        public MainWindow()
        {
            InitializeComponent();
        }

        public void DownloadFile(string urlAddress, string location)
        {
            using (webClient = new WebClient()) //wykorzystujemy using, bo jeśli pójdzie coś nie tak, to zostanie to znisczone 
            {
                webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);

                try
                {
                    webClient.DownloadFileAsync(new Uri(urlAddress), location);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBarDownload.Value = e.ProgressPercentage;
            labelPerc.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            if(e.Cancelled == true)
            {
                MessageBox.Show("Pobieranie zostało przerwane", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                MessageBox.Show("Pobieranie zostało szczęśliwie ukończone", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void buttonDownload_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(urlAddress.Text))
            {
                DownloadFile(urlAddress.Text, Path.Combine(Directory.GetCurrentDirectory(), $"file_{DateTime.Now.ToShortTimeString()}.pdf"));
            }
        }
    }
}
