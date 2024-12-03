using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Trapezoid : Shape
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Height { get; set; }
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public Trapezoid(double base1, double base2, double height, double side1, double side2)
        {
            if (base1 <= 0 || base2 <= 0 || height <= 0 || side1 <= 0 || side2 <=0)
            {
                Console.WriteLine("Invalid input for trapezoid");
            }
            Base1 = base1;
            Base2 = base2;
            Height = height;
            Side1 = side1;
            Side2 = side2;

        }

        public override double GetArea()
        {
            return 0.5 * (Base1 + Base2) * Height;
        }

        public override double GetPerimeter()
        {
            return Base1 + Base2 + Side1 + Side2;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Trapezoid with Base1: {Base1}, Base2: {Base2}, Height: {Height}, Side1: {Side1} and Side2: {Side2} and has Area: {GetArea()}");
        }
    }
}
