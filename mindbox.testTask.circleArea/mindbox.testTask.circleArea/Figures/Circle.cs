using mindbox.testTask.circleArea.Abstract;

namespace mindbox.testTask.circleArea.Figures
{
    public class Circle : RoundFigure
    {
        public Circle(double radius) : base(radius)
        {
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
