using System;

namespace shape_demo
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Square square = new Square("Blue",2);
            Rectangle rectangle = new Rectangle("Yellow",4,5);
            Circle circle = new Circle("Green",2);
            shapes.Add(square);
            shapes.Add(rectangle);
            shapes.Add(circle);

            foreach(Shape shape in shapes){
                string color  = shape.Getcolor();
                double area = shape.GetArea();

                Console.WriteLine($"The {color} shape has an area of {area}.");
            }
        }
    }
}