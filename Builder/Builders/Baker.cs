using Builder.Main;

namespace Builder.Builders
{
    public class Baker
    {
        public Bread Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.CreateBread();
            breadBuilder.SetFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();

            return breadBuilder.Bread;
        }
    }
}
