using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonExecute
    {
        public static void SingletonCommand()
        {
            Singleton myvar = Singleton.GetInstance();
            Console.WriteLine("This is the Singleton pattern. It restricts the instantiation of a class to one object.");
            Console.Write("Please input a message for the only object to write back to you: ");
            string input = Console.ReadLine();
            myvar.DoSomething(input);
            Console.ReadLine();
        }
    }
}
