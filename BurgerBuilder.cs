using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal class BurgerBuilder : IBurgerBuilder
    {
        private Burger burger;

        public BurgerBuilder() 
        {
            burger = new Burger();
        }

        public IBurgerBuilder GetBun() 
        {
            burger.Bun = "булочка с кунжутом светлая";
            return this;
        }
        public IBurgerBuilder GetMeat()
        {
            burger.Meat = "мраморная говядина";
            return this;
        }
        public IBurgerBuilder GetCheese()
        {
            burger.Cheese = "сыр пармезан";
            return this;
        }
        public IBurgerBuilder GetVeggies()
        {
            burger.Vegies = "помидор и красный лук";
            return this;
        }
        public IBurgerBuilder GetSauce()
        {
            burger.Sauce = "соус \"Тысяча островов\"";
            return this;
        }
        public Burger GetBurger() 
        {
            return burger;
        }
    }
}
