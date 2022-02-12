using Decorator.Base;

namespace Decorator.Addons
{
    public class Cream : CondimentDecorator
    {
        public Cream(Beverage beverage)
        {
            _beverage = beverage;
        }

        private Beverage _beverage;

        public override double Cost()
        {
            return 0.1 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Cream";
        }
    }
}
