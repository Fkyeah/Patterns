using Decorator.Base;

namespace Decorator.Addons
{
    public class Soya : CondimentDecorator
    {
        public Soya(Beverage beverage)
        {
            _beverage = beverage;
        }

        private Beverage _beverage;

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soya";
        }
    }
}
