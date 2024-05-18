namespace Task1
{
    abstract class Figure
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void PrintInfo();
        public abstract string Name { get; }
    }
}
