using mindbox.testTask.circleArea.Abstract;

namespace mindbox.testTask.circleArea
{
    public static class GeometryFigure
    {
        //главный класс, предоставляется клиенту
        public static double GetArea(Figure figure)
        {
            //статический метод, принимает какую то фигуру и вызывает у нее переопределенный метод
            return figure.GetArea();
        }
    }
}
