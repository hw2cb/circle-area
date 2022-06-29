using mindbox.testTask.circleArea.Abstract;

namespace mindbox.testTask.circleArea.Figures
{
    public class Triangle : Figure
    {
        #region Property SIDES and Half-Perimeter
        private double _sideA;
        public double SideA 
        { 
            get { return _sideA; } 
            private set 
            { 
                if (value <= 0) throw new ArgumentException("side A should be > 0"); 
                _sideA = value; 
            }
        }

        private double _sideB;
        public double SideB
        {
            get { return _sideB; }
            private set
            {
                if (value <= 0) throw new ArgumentException("side B should be > 0");
                _sideB = value;
            }
        }

        private double _sideC;
        public double SideC
        {
            get { return _sideC; }
            private set
            {
                if (value <= 0) throw new ArgumentException("side C should be > 0");
                _sideC = value;
            }
        }
        private double _halfPerimeter;
        public double HalfPerimeter { get { return _halfPerimeter; } private set { _halfPerimeter = value; } }
        #endregion


        public override double GetArea()
        {
            return Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA)*(HalfPerimeter - SideB)* (HalfPerimeter - SideC));
        }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            HalfPerimeter = (_sideA + _sideB + _sideC) / 2;
        }
        public bool IsRectangular()
        {
            //проверка, явлвяется ли треугольник прямоугольным
            return ((SideA * SideA == SideB*SideB + SideC*SideC) 
                || (SideB*SideB == SideA*SideA + SideC*SideC) 
                || (SideC*SideC == SideA*SideA + SideB*SideB));
        }
    }
}
