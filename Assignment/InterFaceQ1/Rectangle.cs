using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.InterFaceQ1
{
    internal class Rectangle : IRectangle
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void ShapeInfo()
        {
            Console.WriteLine("Shape: Rectangle");
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area:F2}");
        }
    }
}
