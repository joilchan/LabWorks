using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            if (shapeType == null)
                return null;
            if (shapeType.Equals("CIRCLE", StringComparison.InvariantCultureIgnoreCase))
                return new Circle();
            if (shapeType.Equals("RECTANGLE", StringComparison.CurrentCultureIgnoreCase))
                return new Rectangle();
            if (shapeType.Equals("SQUARE", StringComparison.CurrentCultureIgnoreCase))
                return new Square();
            if (shapeType.Equals("TRIANGLE", StringComparison.CurrentCultureIgnoreCase))
                return new Triangle();
            return null;
        }
    }
}