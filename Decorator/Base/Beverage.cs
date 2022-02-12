namespace Decorator.Base
{
    public abstract class Beverage
    {
        protected string _description = "Unknown Beverage";

        public virtual string GetDescription() => _description;

        public abstract double Cost();
    }
}
