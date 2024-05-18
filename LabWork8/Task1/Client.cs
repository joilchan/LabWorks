namespace Task1
{
    internal class Client
    {
        public string Name { get; set; }
        public string Adrress { get; set; }
        public int Sum { get; set; }

        public Client(string name, string adrress, int sum)
        {
            Name = name;
            Adrress = adrress;
            Sum = sum;
        }

        public override string ToString()
            => $"ФИО: {Name}; Адрес: {Adrress}; Потраченная сумма: {Sum}";

        public override bool Equals(object? obj)
        {
            Client client = obj as Client;
            if (client == null)
                return false;
            return Name == client.Name && Adrress == client.Adrress && Sum == client.Sum;
        }
    }
}
