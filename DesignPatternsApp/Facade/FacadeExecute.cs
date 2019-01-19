using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FacadeExecute
    {
        public static void FacadeCommand()
        {
            //I think...
            //Like an architect, a middle man, will do a bunch of tasks. 
            //Object that provides a simplifyed interface to a larger body of code,like a class libary. 
            //Instead of calling all multiple classes and methods in them.
            //Put them all calls in one  method. Instead of class1.method7(), class2.method1(), all in one. 
            //Enough mistakes to not use. 

            bool repeat = true;
            while (repeat)
            {
                CarFacade facade = new CarFacade();

                facade.CreateCompleteCar();
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