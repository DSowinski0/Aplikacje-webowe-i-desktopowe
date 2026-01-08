using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace KolekcjaBinding_3TFgr2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Produkt> Produkty = null;
        int index;

        Produkt p = null;
        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }

        private void PrzygotujWiazanie()
        {
            Produkty = new ObservableCollection<Produkt>
            {
                new Produkt("WP10", "Pióro wieczne", 100, "MG1"),
                new Produkt("DG03", "Długopis", 130, "MG2"),
                new Produkt("HB1000", "Ołówek twardy HB100", 89, "MG2"),
                new Produkt("GM", "Gumka 'Myszka'", 23, "MG3")
            };

            lstProdukty.ItemsSource = Produkty;

        }

        private void Button_Dodaj_Click(object sender, RoutedEventArgs e)
        {
            AddWindow window = new AddWindow(Produkty);

            window.ShowDialog();

        }

        private void Button_Edytuj_Click(object sender, RoutedEventArgs e)
        {
            AddWindow window = new AddWindow(Produkty,lstProdukty.SelectedIndex);
            window.Title = "Edytuj";
            
            window.ShowDialog();

        }

        private void Button_Usun_Click(object sender, RoutedEventArgs e)
        {
            Produkt itemToRemove = lstProdukty.SelectedItem as Produkt;
            var yesno = MessageBox.Show("Czy na pewno chcesz to usunąć", "Usuwanie",MessageBoxButton.YesNo);

            if(yesno == MessageBoxResult.Yes) 
                Produkty.Remove(itemToRemove);
        }

        private void MenuItemZapiszClick(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveWindow = new SaveFileDialog();
            saveWindow.Filter = "Text Files | *.txt";
            saveWindow.DefaultExt = "txt";
   
            saveWindow.ShowDialog();
            StreamWriter sw = new StreamWriter(saveWindow.FileName);
            sw.WriteLine(Produkty[0].Nazwa + ";" + 
                         Produkty[0].LiczbaSztuk.ToString() +";"+
                         Produkty[0].Magazyn);
            sw.Close();

            



        }
    }
}
