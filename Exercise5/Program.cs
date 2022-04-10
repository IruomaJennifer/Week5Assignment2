// See https://aka.ms/new-console-template for more information
using Exercise5;

Shape[] shapes = new Shape[] { new Triangle(5, 6), new Rectangle(4, 9), new Circle(8) };
double[] areasOfShapes = new double[] { shapes[0].CalculateSurface(), shapes[1].CalculateSurface(), shapes[2].CalculateSurface() };
foreach (double area in areasOfShapes)
{
    Console.Write($"{area} ");
}