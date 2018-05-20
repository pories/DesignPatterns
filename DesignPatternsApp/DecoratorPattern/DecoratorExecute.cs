using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class DecoratorExecute
    {
        public static void DecoratorCommand()
        {
            Pizza mypizza = new ThickCrust();
            mypizza = new Pepperoni(mypizza);
            mypizza = new Sausage(mypizza);
            Console.WriteLine("This is the decorator pattern. It allows behaviors to be added to an existing object dynamically during runtime.");
            Console.WriteLine("Here we use a decorator pattern to make a pizza, and add things to it, and then to tell us it's cost.");
            Console.WriteLine($"Pizza costs: {mypizza.cost()}");
            Console.ReadLine();
        }
    }
}
