using Polymorphism;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

internal class Program
{
    private const string fileName = "shapes.dat";
    private static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.WriteLine("Enter a number of shapes to be created:");

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Choose a shape [1] Circle, [2] Rectangle, [3] Triangle, [4] Trapezoid, [5] Pentagon");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius));
                    break;
                case "2":
                    Console.WriteLine("Width:");
                    double width = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height));
                    break;
                case "3":
                    Console.WriteLine("Base:");
                    double _base = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height");
                    double height2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("SideA");
                    double sideA = double.Parse(Console.ReadLine());
                    Console.WriteLine("SideB");
                    double sideB = double.Parse(Console.ReadLine());
                    Console.WriteLine("SideC");
                    double sideC = double.Parse(Console.ReadLine());
                    shapes.Add(new Triangle(_base, height2, sideA, sideB, sideC));
                    break;
                case "4":
                    Console.WriteLine("Base1");
                    double base1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base2");
                    double base2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height");
                    double height1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("SideX");
                    double sideX = double.Parse(Console.ReadLine());
                    Console.WriteLine("SideY");
                    double sideY = double.Parse(Console.ReadLine());
                    shapes.Add(new Trapezoid(base1, base2, height1, sideX, sideY));    
                    break;
                case "5":
                    Console.WriteLine("SideZ");
                    double sideZ = double.Parse(Console.ReadLine());
                    shapes.Add(new Pentagon(sideZ));
                    break;
                case "6":
                    Console.WriteLine("Side");
                    double sideS = double.Parse(Console.ReadLine());
                    shapes.Add(new Square(sideS));
                    break;
                default:
                    Console.WriteLine("Please choose one of shapes");
                    break;
            }

            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(shapes, options);

            // Write the JSON to the file (replace the content with the new list)
            File.WriteAllText(fileName, json);
            Console.WriteLine("Shapes saved to file.");


        }

    }

   

  
}