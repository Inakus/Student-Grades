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

namespace StudentGrades
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Student<float> Students { get; set; }
        List<Student<float>> stud { get; set; }
        List<Ocena<float,float>> ocena { get; set; }

        public MainWindow()
        {
            stud = new List<Student<float>>()
            {
                new Student<float>() { Id = 1, Imie = "Karol", Nazwisko = "Dobrek", NrIndeksu = 11111, Oceny =  ocena },
            };

            ocena = new List<Ocena<float, float>>()
            {
                new Ocena<float, float>() { Id = 1, Data = DateTime.MaxValue, Przedmiot = "Programowanie obiektowe", Wartosc = 4 }
            };

            
            InitializeComponent();

            

            


            DaneG.ItemsSource = stud;
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
        private void DG1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            string headername = e.Column.Header.ToString();

            if(headername == "Oceny")
            {
                e.Cancel = true;
            }
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
            if (DaneG.SelectedIndex >= 0)
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
