using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double _base, double height)
        {
            Base = _base;
            Height = height;
        }

        public override double GetArea()
        {
            return Base * Height * 0.5;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Triangle with base {Base} and height {Height} has area {GetArea()}");
        }
    }
}
