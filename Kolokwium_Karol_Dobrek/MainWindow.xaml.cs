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

namespace Kolokwium_Karol_Dobrek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Student<string>> stud { get; set; }

        List<Ocena<string, string>> ocena { get; set; }

        public MainWindow()
        {
            ocena = new List<Ocena<string, string>>()
            {
                new Ocena<string, string>() { Id = "1", Data = DateTime.MaxValue, Przedmiot = "Programowanie obiektowe", Wartosc = "4" }
            };

            stud = new List<Student<string>>()
            {
                new Student<string>() { Id = "1", Imie = "Karol", Nazwisko = "Dobrek", NrIndeksu = "11111" }
            };
            InitializeComponent();


            DaneG.ItemsSource = stud;
            OcenyG.ItemsSource = ocena;
        }



        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            var wybor = new Wybor();
            if (wybor.ShowDialog() == true)
            {
                stud.Add(wybor.student);
                DaneG.Items.Refresh();
            }
            InitializeComponent();

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Usun_click(object sender, RoutedEventArgs e)
        {
            if (DaneG.SelectedItem != null)
                stud.RemoveAt(DaneG.SelectedIndex);
            DaneG.Items.Refresh();
        }

        private void OcenyG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Usun_ocene_Click(object sender, RoutedEventArgs e)
        {
            if (OcenyG.SelectedItem != null)
                ocena.RemoveAt(OcenyG.SelectedIndex);
            OcenyG.Items.Refresh();
        }

        private void Dodaj_ocene_Click(object sender, RoutedEventArgs e)
        {
            var wybor2 = new Wybor1();
            if (wybor2.ShowDialog() == true)
            {
                ocena.Add(wybor2.ocena);
                OcenyG.Items.Refresh();
            }
            InitializeComponent();
        }

        private void Edycja_Click(object sender, RoutedEventArgs e)
        {
            if (DaneG.SelectedItems != null)
            {
                var list = new Wybor(stud[DaneG.SelectedIndex]);
                if (list.ShowDialog() == true)
                {
                    stud[DaneG.SelectedIndex] = list.student;
                    DaneG.Items.Refresh();
                }
            }
        }
    }
}
