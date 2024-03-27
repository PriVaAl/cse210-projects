using System;
class Program
{
    static void Main(string[] args)
    {
        List<Shape>  shapes = new List<Shape>();

        Square square1 = new Square("Black", 3);
        //square1.GetColor();
        //square1.GetArea();
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle("Red",4,6);
        //rectangle1.GetColor();
        //rectangle1.GetArea();
        shapes.Add(rectangle1);

        Circle circle1 = new Circle("Blue",5);
        //circle1.GetColor();
        //circle1.GetArea();
        shapes.Add(circle1);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
       
    }
}