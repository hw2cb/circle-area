namespace mindbox.testTask.circleArea.Abstract
{
    public abstract class SquareFigure : Figure
    {
        //базовый класс для квадратных фигур, прямоугольник будет расширять этот класс
        private double _sideA;
        public double SideA
        {
            get { return _sideA; }
            //оставлю возможность изменения стороны из вне
            set
            {
                if (value <= 0) throw new ArgumentException("Side should be > 0");
                _sideA = value;
            }
        }
        protected SquareFigure(double sideA)
        {
            SideA = sideA;
        }
    }
}
