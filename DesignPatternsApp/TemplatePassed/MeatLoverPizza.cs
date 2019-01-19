using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePassed
{
    class MeatLoverPizza : Pizza
    {
        //Template Method
        #region
        //below can be removed because it is put in pizza. 
        //public void MakePizza()
        //{

        //    MakeDough();
        //    AddTomatoeSauce();
        //    AddCheese();
        //    AddToppings();
        //}             
        //public void MakeDough()
        //{
        //    Console.WriteLine("Worked the dough.");
        //}
        //public void AddTomatoeSauce()
        //{
        //    Console.WriteLine("Added the sauce.");
        //}
        //public void AddCheese()
        //{
        //    Console.WriteLine("Added the cheese.");
        //}
        //too datailed. We don't care. 
        #endregion
        //must add ovverride. 
        public override void AddToppings()
        {
            Console.WriteLine("Added meat toppings: bacon, peperoni, hamburger. ");
        }

    }
}
