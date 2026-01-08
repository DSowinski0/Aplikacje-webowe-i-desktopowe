using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolekcjaBinding_3TFgr2
{
    public class Produkt
    {
        public String Symbol { get; set; }
        public String Nazwa { get; set; }
        public int LiczbaSztuk { get; set; }
        public String Magazyn { get; set; }
        public Produkt()
        {
            Symbol = null;
            Nazwa = null;
            Magazyn = null;
            LiczbaSztuk = 0;
        }

        public Produkt(String symbol, string nazwa, int lsztuk, String magazyn)
        {
            Symbol = symbol;
            Nazwa = nazwa;
            Magazyn = magazyn;
            LiczbaSztuk = lsztuk;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}, {3}", Symbol, Nazwa, LiczbaSztuk, Magazyn);
        }
    }
}
