using Decorator.Base;

namespace Decorator.Addons
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }

        private Beverage _beverage;

        public override double Cost()
        {
            return 0.20 + _beverage.Cost();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }
    }
}
