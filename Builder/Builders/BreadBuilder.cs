using Builder.Main;

namespace Builder.Builders
{
    public abstract class BreadBuilder
    {
        public Bread Bread { get; set; }

        public void CreateBread()
        {
            Bread = new Bread();
        }

        public abstract void SetFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();
    }
}
