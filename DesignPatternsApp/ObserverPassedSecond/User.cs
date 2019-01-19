using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPassedSecond
{
    public class User : ISubscriber
    {
        public void Notify()
        {
            Console.WriteLine("User was updated about new info.");
            //throw new NotImplementedException();
        }
    }
}
