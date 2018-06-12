using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Pepperoni : Toppings
    {
        public Pepperoni(Pizza myvar2) : base(myvar2)
        {
        }
        public override double cost()
        {
            return 3.75 + pizzaMyVar1.cost();
        }
    }
}
