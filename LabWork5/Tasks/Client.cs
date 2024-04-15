using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class Client
    {
        private string Name { get; set; }
        private string Address { get; set; }
        private int Sum { get; set; }

        public Client(string name, string address, int sum)
        {
            Name = name;
            Address = address;
            Sum = sum;
        }

        public Client() { }

        public void Print()
        {
            Console.WriteLine($"Имя клиента: {Name}, адрес: {Address}, потраченная сумма: {Sum}");
        }
    }
}