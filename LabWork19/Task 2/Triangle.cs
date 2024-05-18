using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2
{
    public class Triangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Inside Triangle::draw() method.");
        }
    }
}