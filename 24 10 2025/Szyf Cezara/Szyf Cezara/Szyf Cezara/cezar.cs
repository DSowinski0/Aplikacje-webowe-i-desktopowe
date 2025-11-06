using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Szyf_Cezara
{
    public class Cezar
    {

        private string _napis;
        private string _szyfrogram;
        private int _klucz;


        public Cezar(string napis, int klucz)
        {


            _napis = napis;
            _klucz = klucz;
           


        }



        public string Szyfruj()
        {


            int kod;
            _szyfrogram = string.Empty;


            if (_klucz > 26) _klucz %= 26;




            for(int i=0; i<_napis.Length; i++)
            {


                var kod = (int)_napis[i];

                kod += _klucz;
                if (kod > 122) kod -= 26 ;
                _szyfrogram += (Char)kod;




            }

            return _szyfrogram;
        }




    }
}
