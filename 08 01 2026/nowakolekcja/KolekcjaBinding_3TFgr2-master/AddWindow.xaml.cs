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
using System.Windows.Shapes;

namespace KolekcjaBinding_3TFgr2
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        
        private ObservableCollection<Produkt> Produkty = null;
        private int index;
        public AddWindow(ObservableCollection<Produkt> produkty,int selectedItemIndex=-1)
        {
            InitializeComponent();
            Produkty = produkty;
            index = selectedItemIndex;
            PrzygotujWiazanie();
            
            
        }

        private void PrzygotujWiazanie()
        {
            if (index>=0) 
            {
                stackProd.DataContext = Produkty[index];

                base.Title = "Edytuj";
                
               

            }
            else
            {
                var btn = stackProd.Children.OfType<Button>().FirstOrDefault();
                btn.Content = "Dodaj";
                stackProd.DataContext = new Produkt();
            }

            
            
        }

        private void Button_Zapisz_Click(object sender, RoutedEventArgs e)
        {
            if (index >= 0)
            {
                Produkty[index] = stackProd.DataContext as Produkt;
                
                
            }
            else
            {   
                
                Produkty.Add(stackProd.DataContext as Produkt);
                
                
            }
            Close();

        }
    }
}
