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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace egzamin
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {

            wyswietl_dane();


        }








        public void wyswietl_dane()
        {


            string imie = Imie.Text;

            string nazwisko = Nazwisko.Text;

            string kolor_oczu = "";


            if (nieb.IsChecked == true)
            {

                kolor_oczu = "Niebieski";


            } else if (ziel.IsChecked == true)
            {

                kolor_oczu = "Zielony";

            } else if (piwn.IsChecked == true)
            {

                kolor_oczu = "Piwny";




            }


            



            if (imie == "" || nazwisko == "")
            {
                string wiadomosc = "Wprowadź dane.";

                MessageBox.Show(wiadomosc);




            } else if (imie != "" && nazwisko != "")
            {


                string wiadomosc = imie + " " + nazwisko + " " +  $"kolor oczu {kolor_oczu}";


                MessageBox.Show(wiadomosc);


            }



        }

        private void Zmien_zdjecie(object sender, TextChangedEventArgs e)
        {



            string numer = Numer.Text;



            if (numer == "333")
            {
                zdjecie.Visibility = Visibility.Visible;
                odcisk.Visibility = Visibility.Visible;
                zdjecie.Source = new BitmapImage(new Uri("/zdjecia/333-zdjecie.jpg", UriKind.Relative));
                odcisk.Source = new BitmapImage(new Uri("/zdjecia/333-odcisk.jpg", UriKind.Relative));

                


            }
            else if (numer == "111")
            {

                zdjecie.Visibility = Visibility.Visible;
                odcisk.Visibility = Visibility.Visible;
                zdjecie.Source = new BitmapImage(new Uri("/zdjecia/111-zdjecie.jpg", UriKind.Relative));
                odcisk.Source = new BitmapImage(new Uri("/zdjecia/111-odcisk.jpg", UriKind.Relative));

            }
            else if (numer == "000")
            {
                zdjecie.Visibility = Visibility.Visible;
                odcisk.Visibility = Visibility.Visible;
                zdjecie.Source = new BitmapImage(new Uri("/zdjecia/000-zdjecie.jpg", UriKind.Relative));
                odcisk.Source = new BitmapImage(new Uri("/zdjecia/000-odcisk.jpg", UriKind.Relative));
            }
            else
            {

                zdjecie.Visibility = Visibility.Hidden;
                odcisk.Visibility = Visibility.Hidden;


            }





        }
    }
}
