using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfApplication1
{
    class MojaKlasa
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public char dzialanie;
        public float wynik;
        bool znak_dodac = false;
        bool znak_minus = false;
        public bool sprawdzam_pp = false;
        
    //MojaKlasa Obiekt_Licz = new MojaKlasa(); 
    
    
        public void Dodaj(){
            wynik = x + y;
        }

        public void Odejmij()
        {
            wynik = x - y;
        }

    }


    
    class Sprawdzam{
           
        public bool liczba1, liczba2;
           public Sprawdzam()
            {
                liczba1 = false;
                liczba2 = false;
            }
    }
   
    
}
