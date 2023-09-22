using Kitchen;

var builder = new BurgerBuilder();
Console.WriteLine(builder.GetBun().GetCheese().GetVeggies().GetSauce().GetBurger().ToString());
