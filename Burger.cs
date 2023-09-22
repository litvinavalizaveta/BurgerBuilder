using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen
{
    internal class Burger
    {
        public string Bun { get; set; }
        public string Meat { get; set; }
        public string Cheese { get; set; }
        public string Vegies { get; set; }
        public string Sauce { get; set; }
        public override string ToString() 
        {
            var nonEmptyFields = new[] { Bun, Meat, Cheese, Vegies, Sauce }.Where(field => !string.IsNullOrEmpty(field));
            return $"Текущий бургер: {string.Join("+", nonEmptyFields)}.";
        }
    }
}
