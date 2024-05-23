using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Patient
    {
        public string Name { get; set; }
        public int Policy { get; set; }
        public DateTime BirthDate { get; set; }

        public override string ToString()
            => $" ФИО: {Name.ToUpper()}\n" +
               $" Полис: {Policy:000000000}\n" +
               $" Срок годности: {BirthDate:yyyy dd mm}";
    }
}
