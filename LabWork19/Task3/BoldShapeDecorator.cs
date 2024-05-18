using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    public class BoldShapeDecorator : ShapeDecorator
    {
        public IShape decoratedShape;

        public BoldShapeDecorator(IShape decoratedShape) : base(decoratedShape){}

        public override void Draw()
        {
            decoratedShape.Draw();
            SetBoldBorder(decoratedShape);
        }

        private void SetBoldBorder(IShape decoratedShape) 
            => Console.WriteLine("Font: border");
    }
}