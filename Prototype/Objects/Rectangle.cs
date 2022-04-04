using Prototype.Interfaces;

namespace Prototype.Objects
{
    public class Rectangle : IFigure
    {
        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }

        private readonly int _width;
        private readonly int _height;

        public IFigure Clone()
        {
            return new Rectangle(_width, _height);
        }

        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}", _height, _width);
        }
    }
}
