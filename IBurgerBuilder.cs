using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal interface IBurgerBuilder
    {
        IBurgerBuilder GetBun();
        IBurgerBuilder GetMeat();
        IBurgerBuilder GetCheese();
        IBurgerBuilder GetVeggies();
        IBurgerBuilder GetSauce();
        Burger GetBurger();
    }
}
