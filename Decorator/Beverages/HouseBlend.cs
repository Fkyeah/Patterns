using Decorator.Base;

namespace Decorator.Beverages
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            _description = "House Blend Coffee";
        }

        public override double Cost() => 0.89;
    }
}
