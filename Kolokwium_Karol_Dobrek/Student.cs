using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGrades
{
    public class Student<S> : Element<S>
    {
        public string? Imie { get; set; }
        public string? Nazwisko { get; set; }
        public S? NrIndeksu { get; set; }
        public List<Ocena<float, S>>? Oceny { get; set; }

        public Student()
        {
            Imie = string.Empty;
            Nazwisko = string.Empty;
            NrIndeksu = default(S);
            Oceny = new List<Ocena<float, S>>();
        }
        public Student(string imie, string nazwisko, S nrIndeksu, List<Ocena<float,S>> oceny)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NrIndeksu = nrIndeksu;
            Oceny = oceny;
        }
        public Student(List<Student<S>> student)
        {
            student = new List<Student<S>>()
            {
                new Student<S>(){Id = this.Id, Imie = this.Imie, Nazwisko = this.Nazwisko, NrIndeksu = this.NrIndeksu, Oceny = this.Oceny}
            };
        }
            

    }
}
