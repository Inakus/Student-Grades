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
        public Ocena<float,float> ocena { get; set; }

        public Wybor1(Ocena<float, float>? Ocena = null)
        { 
            InitializeComponent();
            float ocenaId;
            bool validID = float.TryParse(Id.Text, out ocenaId);
            float ocenaWartosc;
            bool validIndex = float.TryParse(Wartosc.Text, out ocenaWartosc);
            if (ocena != null)
            {
                ocenaId = Ocena.Id;
                Przedmiot.Text = Ocena.Przedmiot;
                Data.DataContext = Ocena.Data;
                ocenaWartosc = Ocena.Wartosc;
            }
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            float ocenaId;
            bool validID = float.TryParse(Id.Text, out ocenaId);
            float ocenaWartosc;
            bool validIndex = float.TryParse(Wartosc.Text, out ocenaWartosc);
            ocena = new Ocena<float, float>
            {
                Id = ocenaId,
                Przedmiot = Przedmiot.Text,
                Wartosc = ocenaWartosc
            };

            DialogResult = true;
        }
    }
}
