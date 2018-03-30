using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryExecute
    {
        public static void FactoryCommand()
        {


            var FactoryPatternExample1Of2 = ObjectFactory.Create(true);
            var FactoryPatternExample2Of2 = ObjectFactory.Create(false);
            Console.WriteLine("This is the Factory Method pattern. It is used for creating objects without having to specify the exact class of the object that will be created.");
            Console.WriteLine("Here we have created two objects and didn't specify the exact class of the object when it was created.");
            FactoryPatternExample1Of2.SomethingInteresting();
            FactoryPatternExample2Of2.SomethingInteresting();
            Console.WriteLine("Press enter when you are done reading.");
            Console.ReadLine();

        }
    }
}
