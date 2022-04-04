using Prototype.Interfaces;

namespace Prototype.Objects
{
    public class Circle : IFigure
    {
        public Circle(int radius)
        {
            _radius = radius;
        }

        private int _radius;
        public IFigure Clone()
        {
            return new Circle(_radius);
        }

        public void GetInfo()
        {
            Console.WriteLine("Круг с радиусом {0}", _radius);
        }
    }
}
