using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Client : IComparable, IComparable<Client>, IEquatable<Client>, ICloneable
    { 
        public string Name { get; set; }
        public string Address { get; set; }
        public int Sum { get; set; }

        public Client(string name, string address, int sum)
        {
            Name = name;
            Address = address;
            Sum = sum;
        }

        public override string ToString()
            => $"ФИО: {Name}; Адрес: {Address}; Потраченная сумма: {Sum}";

        public int CompareTo(object? obj)
        {
            if (obj is Client client)
                return Sum.CompareTo(client.Sum);
            return -1;
        }

        public int CompareTo(Client? other)
        {
            if (other != null)
                return Sum.CompareTo(other.Sum);
            return -1;
        }

        public bool Equals(Client? other)
        {
            if (other == null) 
                return false;
            return Name == other.Name && Address == other.Address && Sum == other.Sum;
        }

        public object Clone()
        {
            return new Client(Name, Address, Sum);
        }
    }
}
