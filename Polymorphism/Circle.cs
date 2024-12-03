using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    [Serializable]
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                Console.WriteLine("Radius cannot be a negative value");
                return;
            }
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;

        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Circle with Radius: {Radius} and has Area: {GetArea()}");
        }
    }
}
