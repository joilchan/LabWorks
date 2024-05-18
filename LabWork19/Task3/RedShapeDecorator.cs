using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Task3
{
    public class RedShapeDecorator : ShapeDecorator
    {
        public IShape decoratedShape;

        public RedShapeDecorator(IShape decoratedShape) : base(decoratedShape){}

        public override void Draw()
        {
            decoratedShape.Draw();
            SetRedBorder(decoratedShape);
        }

        private void SetRedBorder(IShape decoratedShape)
            => Console.WriteLine("Border Color: Red");
    }
}