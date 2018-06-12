using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ConcreteBusinessObject1 : IAbstractionInterface1
    {
        public ConcreteBusinessObject1(string Name)
        {
            //You can do more here.
        }

        public void SomethingInteresting()
        {
            Console.WriteLine("This is the first object we made.");
        }
    }
}
