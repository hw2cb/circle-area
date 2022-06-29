using mindbox.testTask.circleArea.Abstract;

namespace mindbox.testTask.circleArea.Figures
{
    public class Square : SquareFigure
    {
        public Square(double sideA) : base(sideA)
        {
        }

        public override double GetArea()
        {
            return SideA * SideA;
        }
    }
}
