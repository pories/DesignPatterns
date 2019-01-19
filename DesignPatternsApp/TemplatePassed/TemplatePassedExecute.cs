using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePassed
{
    public class TemplatePassedExecute
    {
        public static void TemplatePassedCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                //Template method program skeleton of an algorithm. One or more of the algorithm
                //steps can be overridden by subclasses to allow differing 
                //behaviors while ensuring that the overarching algorithm is still followed. 
                //A few will be overriden by subclasses. 
                //Relies on inheritance and abstract methods. 

                Pizza mlp = new MeatLoverPizza();
                Console.WriteLine("Now we will print out the steps for making a Meat Lovers Pizza.");
                mlp.MakePizza(); //Will print out steps for meat lover pizza.
                Console.WriteLine();
                mlp = new VeggiePizza();
                Console.WriteLine("Now we will print out the steps for making a Veggie Pizza.");
                mlp.MakePizza(); //Will print out steps for veggie pizza.
                Console.Write("Go again? Y/N: ");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
        }
    }
}
