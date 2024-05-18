namespace Task2
{
    interface IFigure
    {
        int GetArea();
        int GetPerimeter();
        void PrintInfo();
        public string Name { get; }
    }
}
