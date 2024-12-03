using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Square : Shape
    {
        public double Side { get; set; }
        public Square(double side)
        {
            if (side <= 0)
            {
                Console.Write("Side value cannot be negative");
            }
            Side = side;    

        }
        public override double GetArea()
        {
            return Side * Side;
        }

        public override double GetPerimeter()
        {
            return 4 * Side;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Square with Side: {Side} and has Area: {GetArea()}");
        }
    }
}
