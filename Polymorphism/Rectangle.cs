using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    [Serializable]
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            if (width <= 0 && width <= 0)
            {
                Console.WriteLine("Width and Height cannot be a negative value");
                return;
            }
            Width = width;
            Height = height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Rectangle with Width: {Width} and Height {Height} and has Area: {GetArea()}");
        }
    }
}
