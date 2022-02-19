using Factory.Base.Interfaces;
using System;

namespace Factory.Subjects
{
    public class ClamPizza : IPizza
    {
        public void Bake()
        {
            throw new NotImplementedException();
        }

        public void Box()
        {
            throw new NotImplementedException();
        }

        public void Cut()
        {
            throw new NotImplementedException();
        }

        public void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
