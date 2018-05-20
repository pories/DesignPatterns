using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public abstract class Toppings : Pizza
    {
        public Pizza pizzaMyVar1 { get; set; }

        public Toppings(Pizza myvar2)
        {
            pizzaMyVar1 = myvar2;
        }
    }
}
