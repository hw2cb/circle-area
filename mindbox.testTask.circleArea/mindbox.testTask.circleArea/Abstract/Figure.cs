namespace mindbox.testTask.circleArea.Abstract
{
    public abstract class Figure
    {
        //базовый абстрактный класс, наследники обязуются переопределять метод получения площади
        public abstract double GetArea();
        protected Figure()
        {

        }
    }
}
