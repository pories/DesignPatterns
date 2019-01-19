using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePassed
{
    public abstract class Pizza
    {
        public void MakePizza()
        {
            MakeDough();
            AddTomatoeSauce();
            AddCheese();
            AddToppings();
        }

        public void MakeDough()
        {
            Console.WriteLine("Worked the dough.");
        }
        public void AddTomatoeSauce()
        {
            Console.WriteLine("Added the sauce.");
        }
        public void AddCheese()
        {
            Console.WriteLine("Added the cheese.");
        }
        public abstract void AddToppings();
    }
}
