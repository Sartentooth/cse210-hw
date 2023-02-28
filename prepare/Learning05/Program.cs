using System;

namespace Learning05
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square("green", 2.0, "square");
            Rectangle rectangle = new Rectangle("White", 3, 4, "rectangle");
            Circle circle = new Circle("Grey", 2, "circle");

            List<Shape> listOfShapes = new List<Shape>();

            listOfShapes.Add(square);
            listOfShapes.Add(rectangle);
            listOfShapes.Add(circle);

            foreach (Shape shape in listOfShapes)
            {
                Console.WriteLine($"Area of a {shape.GetName()} shape: {shape.GetArea(),0:F2} - Color: {shape.GetColor()}");
            }
        }
    }
}