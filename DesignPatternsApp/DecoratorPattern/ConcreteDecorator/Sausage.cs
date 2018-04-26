using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Sausage : Toppings
    {
        public Sausage(Pizza myvar2) : base(myvar2)
        {
        }
        public override double cost()
        {
            return 3.50 + pizzaMyVar1.cost();
        }
    }
}