using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    class Client : IPrinter
    {
        public Client(string name, string address, int sum)
        {
            Name = name;
            Address = address;
            Sum = sum;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public int Sum { get; set; }

        public override string ToString()
            => $"ФИО: {Name}; Адрес: {Address}; Потраченная сумма: {Sum}";

        public void Print()
        {
            Console.WriteLine($"ФИО: {Name}; Адрес: {Address}; Потраченная сумма: {Sum}");
        }
    }
}
