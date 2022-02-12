using Decorator.Base;

namespace Decorator.Beverages
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            _description = "Coffee Without Cafein";
        }

        public override double Cost() => 1.05;
    }
}
