using Decorator.Base;

namespace Decorator.Beverages
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            _description = "Dark Roast";
        }

        public override double Cost() => 0.99;
    }
}
