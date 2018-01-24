using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        MojaKlasa Obiekt_Licz = new MojaKlasa();
        Sprawdzam sprawdz = new Sprawdzam();
        Window sprawdzam_s = new Window();
        

        public MainWindow()
        {
            InitializeComponent();
            //this.Wynik.Text = "0";
        }
 
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            Obiekt_Licz.dzialanie = '+';
            Obsluz();
            Aktualizuj();
        }


        private void Odejmij_Click(object sender, RoutedEventArgs e)
        {
            Obiekt_Licz.dzialanie = '-';
            Obsluz();
            Aktualizuj();
        }

        private void Mnoz_Click_1(object sender, RoutedEventArgs e)
        {
            Obsluz();
            Obiekt_Licz.dzialanie = '*';
            Aktualizuj();
        }

        private void Dziel_Click(object sender, RoutedEventArgs e)
        {
            Obsluz();
            Obiekt_Licz.dzialanie = '/';
            Aktualizuj();
        }

        private void RownaSie_Click(object sender, RoutedEventArgs e)
        {
            if ((sprawdz.liczba1 == true) && (sprawdz.liczba2 == false))
            {
                sprawdz.liczba2 = true;
                Obiekt_Licz.y = float.Parse(this.Wynik.Text, System.Globalization.CultureInfo.InvariantCulture); // konwertuję ciąg znaków na int
                this.Wynik.Text = "";
            }

            if ((sprawdz.liczba1 == true) && (sprawdz.liczba2 == true))
            {
                this.Wynik.Text = "";

                if (Obiekt_Licz.dzialanie == '+')
                {
                    Obiekt_Licz.wynik = Obiekt_Licz.x + Obiekt_Licz.y;
                    this.Wynik.Text += Obiekt_Licz.wynik;
                }

                if (Obiekt_Licz.dzialanie == '-')
                {
                    Obiekt_Licz.wynik = Obiekt_Licz.x - Obiekt_Licz.y;
                    this.Wynik.Text += Obiekt_Licz.wynik;
                }

                if (Obiekt_Licz.dzialanie == '/')
                {
                    Obiekt_Licz.wynik = Obiekt_Licz.x / Obiekt_Licz.y;
                    this.Wynik.Text += Obiekt_Licz.wynik;
                }

                if (Obiekt_Licz.dzialanie == '*')
                {
                    Obiekt_Licz.wynik = Obiekt_Licz.x * Obiekt_Licz.y;
                    this.Wynik.Text += Obiekt_Licz.wynik;
                }
                //Obiekt_Licz.wynik = 0;
            }
            Obiekt_Licz.x = Obiekt_Licz.wynik;
            Aktualizuj();
        }



        private void Wyczysc_Click(object sender, RoutedEventArgs e)
        {
            this.Wynik.Text = "";
            Obiekt_Licz.wynik = 0;
            Obiekt_Licz.x = 0;
            Obiekt_Licz.y = 0;
            sprawdz.liczba1 = false;
            sprawdz.liczba2 = false;
        }
     

        public void listBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
        private void Sprawdzam_Click(object sender, RoutedEventArgs e)
        {
            Aktualizuj();
        }

       // public event KeyPressEventHandler KeyPress;

        private void AktualizujDane(object sender, RoutedEventArgs e)
        {
            this.Wynik.Text += (sender as Button).Content.ToString();
            listBox1.Items.Clear();
            listBox1.Items.Add("wynik " + Obiekt_Licz.wynik);
            listBox1.Items.Add("x " + Obiekt_Licz.x);
            listBox1.Items.Add("y " + Obiekt_Licz.y);

        }
 
        private void Aktualizuj()
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("wynik " + Obiekt_Licz.wynik);
            listBox1.Items.Add("x " + Obiekt_Licz.x);
            listBox1.Items.Add("y " + Obiekt_Licz.y);

        }

        private void Przecinek_Click(object sender, RoutedEventArgs e)
        {
            this.Wynik.Text += ".";
        }


        public void Obsluz()
        {
            if (this.Wynik.Text == "") // gdy użytkownik naciśnie "+" bez wcześniejszego wskazania liczby
            {
                Obiekt_Licz.x = 0;
            }

            if (this.Wynik.Text == "0") // gdy użytkownik naciśnie "+" bez wcześniejszego wskazania liczby lub gdy liczba będzie się zaczynała wartością"0"
            {
                this.Wynik.Text = "";
                Obiekt_Licz.x = 0;
            }

            if (this.Wynik.Text != "0" && this.Wynik.Text != "" && sprawdz.liczba1 == false) // sprawdzam czy nie jest wpisane "0" lub puste pole
            {
                sprawdz.liczba1 = true;
                Obiekt_Licz.x = float.Parse(this.Wynik.Text, System.Globalization.CultureInfo.InvariantCulture); // konwertuję ciąg znaków na int
                this.Wynik.Text = "";
            }

            if (this.Wynik.Text != "0" && this.Wynik.Text != "" && sprawdz.liczba1 == true && sprawdz.liczba2 == true) // sprawdzam czy nie jest wpisane "0" lub puste pole
            {
                sprawdz.liczba1 = true;
                sprawdz.liczba2 = false;

                this.Wynik.Text = "";
            }

            if (sprawdz.liczba1 == true)
            {
                this.Wynik.Text = "";
            }
        }

       
        

    }
}
