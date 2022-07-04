using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokwium_Karol_Dobrek
{
    public class Ocena<T,S>: Element<T>
    { 
        public DateTime Data { get; set; }
        public string? Przedmiot { get; set; }
        public T? Wartosc { get ; set ; }
    }
}
