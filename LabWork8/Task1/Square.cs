namespace Task1
{
    class Square : Figure
    {
        public Square(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public override double GetArea()
            => Width * Height;

        public override double GetPerimeter()
            => (Height + Width) * 2;

        public override void PrintInfo()
            => Console.WriteLine($"{Name}  ширина: {Width}; высота: {Height};");

        public override string Name 
            => $"Квадрат";
    }
}
