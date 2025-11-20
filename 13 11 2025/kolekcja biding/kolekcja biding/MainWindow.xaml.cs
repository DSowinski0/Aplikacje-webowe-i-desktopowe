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

namespace kolekcja_biding
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private ObservableCollection<produkt> Produkty = null;



        public MainWindow()
        {
            InitializeComponent();
            PrzygotujWiazanie();
        }


        private void PrzygotujWiazanie()
        {

            Produkty = new ObservableCollection<produkt>();
            Produkty.Add(new produkt("WP10", "Pióro wieczne", 100, "MG1"));
            Produkty.Add(new produkt("WP11", "Piórnik", 50, "MG2"));
            Produkty.Add(new produkt("WP12", "Temperówka", 1000, "MG3"));
            Produkty.Add(new produkt("WP13", "Ołowek", 300, "MG4"));






        }



     



    }
}
