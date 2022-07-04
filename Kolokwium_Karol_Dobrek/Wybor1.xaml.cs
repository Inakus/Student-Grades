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
using System.Windows.Shapes;

namespace Kolokwium_Karol_Dobrek
{
    /// <summary>
    /// Logika interakcji dla klasy Wybor1.xaml
    /// </summary>
    public partial class Wybor1 : Window
    {
        public Ocena<string,string> ocena { get; set; }

        public Wybor1(Ocena<string, string> Ocena = null)
        {
            InitializeComponent();
            if(ocena != null)
            {
                Id.Text = Ocena.Id;
                Przedmiot.Text =Ocena.Przedmiot;
                Data.DataContext = Ocena.Data;
                Wartosc.Text =Ocena.Wartosc;
            }
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            ocena = new Ocena<string, string>
            {
                Id = Id.Text,
                Przedmiot = Przedmiot.Text,
                Wartosc = Wartosc.Text
            };

            DialogResult = true;
        }
    }
}
