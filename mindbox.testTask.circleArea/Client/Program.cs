

using mindbox.testTask.circleArea;
using mindbox.testTask.circleArea.Figures;

class Program
{
    public static void Main()
    {
        Circle circle = new Circle(15);

        Triangle triangle = new Triangle(5, 25, 4);

        Square square = new Square(10);

        Rectangle rectangle = new Rectangle(5, 5);

        Ring ring = new Ring(5, 10);

        Console.WriteLine(triangle.IsRectangular());

        Console.WriteLine(GeometryFigure.GetArea(ring));
    }
}