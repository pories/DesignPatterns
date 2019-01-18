using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class ProxyExecute
    {
        public static void ProxyCommand()
        {

            bool repeat = true;
            while (repeat)
            {
                ProxyClient proxy = new ProxyClient();
                Console.WriteLine("Data from Proxy Client = {0}", proxy.GetData());


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