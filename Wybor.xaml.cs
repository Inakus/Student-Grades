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

namespace StudentGrades
{
    /// <summary>
    /// Logika interakcji dla klasy Wybor.xaml
    /// </summary>
    public partial class Wybor : Window
    {
        //private Student<string> Student;
        public Student<float> student { get; set; }
        public Wybor(Student<float>? Student = null)
        {
            InitializeComponent();
            float studentId;
            float studentIndex;
            bool validId = float.TryParse(Id.Text, out studentId);
            bool validIndex = float.TryParse(NrIndeksu.Text, out studentIndex);
            if (Student != null)
            {
                Imie.Text = Student.Imie;
                Nazwisko.Text = Student.Nazwisko;
                studentId = Student.Id;
                studentIndex = Student.NrIndeksu;
            }
        }

        private void Dodaj_Click(object sender, RoutedEventArgs e)
        {
            float studentId;
            float studentIndex;
            bool validId = float.TryParse(Id.Text, out studentId);
            bool validIndex = float.TryParse(NrIndeksu.Text, out studentIndex);
            student = new Student<float>()
            {
                Id = studentId,
                Imie = Imie.Text,
                Nazwisko = Nazwisko.Text,
                NrIndeksu = studentIndex,
            };

            DialogResult = true;
        }
    }
}
