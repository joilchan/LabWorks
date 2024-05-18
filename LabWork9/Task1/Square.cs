namespace Task1
{
    class Square : IPrinter
    {
        public Square(int side)
        {
            Side = side;
        }

        public int Side { get; set; }

        public override string ToString() => $"Cторона квадрата: {Side}";

        public void Print()
        {
            Console.WriteLine($"Cторона квадрата: {Side}");
        }
    }
}
