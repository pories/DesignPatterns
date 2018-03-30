using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ObjectFactory
    {
         
        public static IAbstractionInterface1 Create(bool TORF)
        {
            if (TORF)
            {
              
                return new ConcreteBusinessObject("Mike");
            }
            else
            {                
                return new ConcreteBusinessObject2("Pories");
            }
        }
    }
}