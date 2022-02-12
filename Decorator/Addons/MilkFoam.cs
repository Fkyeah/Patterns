using Decorator.Base;

namespace Decorator.Addons
{
    public class MilkFoam : CondimentDecorator
    {
        public MilkFoam(Beverage beverage)
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
            return _beverage.GetDescription() + ", MilkFoam";
        }
    }
}
