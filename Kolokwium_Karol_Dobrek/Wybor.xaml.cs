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
    /// Logika interakcji dla klasy Wybor.xaml
    /// </summary>
    public partial class Wybor : Window
    {
        //private Student<string> Student;
        public Student<string> student { get; set; }
        public Wybor(Student<string> Student = null)
        {
            InitializeComponent();
            if(Student != null)
            {
                Imie.Text = Student.Imie;
                Nazwisko.Text = Student.Nazwisko;
                Id.Text = Student.Id;
                NrIndeksu.Text = Student.NrIndeksu;
            }
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            student = new Student<string>()
            {
                Id = Id.Text,
                Imie = Imie.Text,
                Nazwisko = Nazwisko.Text,
                NrIndeksu = Id.Text,
            };

            DialogResult = true;
        }
    }
}
