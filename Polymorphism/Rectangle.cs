using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;        
        }
        public override double GetArea()
        {
            return Width * Height;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with {Width} and height {Height} has area {GetArea()}");

        }


    }
}
