using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class InterpreterExecute
    {
        public static void InterpreterCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("This needs work!");
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