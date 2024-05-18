namespace Task2
{
    internal class Square : IFigure
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public override string ToString() => $"Сторона квадрата равна {Side}";

        public string Name => "фигура";

        public int GetArea()
        {
            return Side * Side;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Cторона квадрата: {Side}");
        }

        public int GetPerimeter()
        {
            return Side * 4;
        }
    }
}
