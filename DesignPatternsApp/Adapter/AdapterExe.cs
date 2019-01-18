using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterExe
    {
        public static void Execute()
        {
            bool repeat = true;
            while (repeat)
            {
                ITarget Itarget = new EmployeeAdapter();
                ThirdPartyBillingSystem client = new ThirdPartyBillingSystem(Itarget);
                client.ShowEmployeeList();
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
