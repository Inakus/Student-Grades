using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_Karol_Dobrek
{
    public class Student<S>: Element<S>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public S NrIndeksu { get; set; }

        public List<Ocena<float,S>> Oceny { get; set; }
    }
}
