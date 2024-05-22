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
               $" Полис: {String.Format("{0:000000000}", Policy)}\n" +
               $" Срок годности: {String.Format("{0:yyyy dd mm}", BirthDate)}";
    }
}
