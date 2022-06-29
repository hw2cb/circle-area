using mindbox.testTask.circleArea.Abstract;

namespace mindbox.testTask.circleArea.Figures
{
    public class Ring : RoundFigure
    {
        //фигура кольцо

        //внешний круг
        private Circle _outerCircle;
        //внутренний круг
        private Circle _innerCircle;

        public Ring(double _innerRadius, double _outerRadius) : base(_innerRadius)
        {
            if (_innerRadius > _outerRadius) throw new ArgumentException("The radius of the inner circle should not be larger than the outer circle");
            //будем считать, что радиус кольца это расстояние от середины, до внутреннего круга
            _outerCircle = new Circle(_outerRadius);
            _innerCircle = new Circle(_innerRadius);

        }

        public override double GetArea()
        {
            return Math.PI * (Math.Pow(_outerCircle.Radius, 2) - Math.Pow(_innerCircle.Radius, 2));
        }
    }
}
