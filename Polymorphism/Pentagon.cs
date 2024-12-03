using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Pentagon : Shape
    {
        public double Side { get; set; }
        public Pentagon(double side)
        {
            if (side <= 0)
            {
                Console.WriteLine("Side cannot be negative");
                return;
            }
            Side = side;    

        }

        public override double GetArea()
        {
            return 1.72 * Side * Side;  
        }

        public override double GetPerimeter()
        {
            return 5 * Side;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Pentagon with Side: {Side} and has Area: {GetArea()}");
        }
    }
}
