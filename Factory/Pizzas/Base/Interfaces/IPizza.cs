using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas.Base.Interfaces
{
    public interface IPizza
    {
        void Prepare();
        void Cut();
        void Box();
        void Bake();
    }
}
