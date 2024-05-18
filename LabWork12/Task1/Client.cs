namespace Task1
{
    internal struct Client
    {
        private string name;
        private string address;
        private int sum;


        public Client(string name, string address, int sum)
        {
            this.Name = name;
            this.Address = address;
            this.Sum = sum;
        }

        public string Name
        {
            get => name;
            set
            {
                if (value.Length > 0)
                    name = value;
            }
        }

        public string Address
        {
            get => address;
            set
            {
                if (value.Length > 0)
                    address = value;
            }
        }

        public int Sum
        {
            get => sum;
            set
            {
                if (value >= 0)
                    sum = value;
            }
        }

        public void Print()
            => Console.WriteLine($"{$"ФИО: {Name}; Адрес: {Address}; Потраченная сумма: {Sum}"}");
    }
}
