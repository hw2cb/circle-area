using mindbox.testTask.circleArea.Abstract;

namespace mindbox.testTask.circleArea.Figures
{
    public class Rectangle : SquareFigure
    {
        private double _sideB;
        public double SideB
        {
            get { return _sideB; }
            set
            {
                if (value <= 0) throw new ArgumentException("Side B should be > 0");
                _sideB = value;
            }

        }
        public Rectangle(double sideA, double sideB) : base(sideA)
        {
            SideB = sideB;
        }

        public override double GetArea()
        {
            return SideA * SideB;
        }

    }
}
