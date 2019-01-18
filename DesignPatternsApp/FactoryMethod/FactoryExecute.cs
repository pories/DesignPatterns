using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class FactoryExecute
    {
        public static void Execute()
        {
            bool repeat = true;
            while (repeat)
            {
                //var FactoryPatternExample1Of2 = ObjectFactory.Create(true);
                //var FactoryPatternExample2Of2 = ObjectFactory.Create(false);
                //Console.WriteLine("This is the Factory pattern. It is used for creating objects without having to specify the exact class of the object that will be created.");
                //Console.WriteLine("Here we have created two objects and didn't specify the exact class of the object when it was created.");
                //FactoryPatternExample1Of2.SomethingInteresting();
                //FactoryPatternExample2Of2.SomethingInteresting();
                //Console.WriteLine("Press enter when you are done reading.");
                //Console.ReadLine();
                bool myvar3torf;
            bool myvar4torf;
            Console.WriteLine("This is the Factory pattern. It is used for creating objects without having to specify the exact class of the object that will be created.");
            Console.WriteLine("Here we have created two objects and didn't specify the exact class of the object when it was created.");
            Console.WriteLine("Enter T to create object 1, and F to create object 2.");
            Console.Write("Please enter a T/F value for first object: ");
            string myvar1torf = Console.ReadLine().ToLower();
            if (myvar1torf == "t")
            {
                myvar3torf = true;
            }
            else
            {
                myvar3torf = false;
            }
            Console.Write("Please enter a T/F value for second object: ");
            string myvar2torf = Console.ReadLine().ToLower();
            if (myvar2torf == "t")
            {
                myvar4torf = true;
            }
            else
            {
                myvar4torf = false;
            }
            var myvar1 = ObjectFactory.Create(myvar3torf);
            var myvar2 = ObjectFactory.Create(myvar4torf);
            myvar1.SomethingInteresting();
            myvar2.SomethingInteresting();
            Console.WriteLine("Press enter when you are done reading.");
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
