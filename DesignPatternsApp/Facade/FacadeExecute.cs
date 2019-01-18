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