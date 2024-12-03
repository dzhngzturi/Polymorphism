using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    [Serializable]
    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double _base, double height, double sideA, double sideB, double sideC)
        {
            if (_base <= 0 || height <= 0 || sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                Console.WriteLine("Base, Height, SideA, SideB or SideC cannot be a negative value");
                return;
            }

            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                Console.WriteLine("The sum of any two sides of a triangle must be greater than the third side.");
                return;
            }
            Base = _base;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetArea()
        {
            return Base * Height * 0.5;
        }

        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Triangle with Base: {Base} and Height: {Height} and has Area: {GetArea()}");
        }
    }
}
