namespace mindbox.testTask.circleArea.Abstract
{
    public abstract class RoundFigure : Figure
    {
        //базовый класс для круглых фигур
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            //оставлю возможность изменения радиуса из вне
            set
            {
                if (value <= 0) throw new ArgumentException("Radius should be > 0");
                _radius = value;
            }
        }
        protected RoundFigure(double radius)
        {
            Radius = radius;
        }

    }
}
