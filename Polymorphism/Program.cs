using Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Console.WriteLine("Enter a number of shapes to be created:");

        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Choose a shape [1] Circle, [2] Rectangle, [3] Triangle");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Radius:");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle (radius));
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
                    shapes.Add(new Triangle(_base, height2));
                    break;
                default:
                    Console.WriteLine("Please choose one of shapes");
                    break;
            }
        }

        foreach (Shape shape in shapes)
        {
            shape.GetArea();
            shape.DisplayInfo();
        }
    }
}