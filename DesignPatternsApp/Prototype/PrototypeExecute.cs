using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class PrototypeExecute
    {
        public static void PrototypeCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                Developer dev = new Developer();
                dev.Name = "Mike";
                dev.Role = "Team Leader";
                dev.PreferredLanguage = "C#";

                Developer devCopy = (Developer)dev.Clone();
                devCopy.Name = "Paul"; //Not mention Role and PreferredLanguage, it will copy above

                Console.WriteLine(dev.GetDetails());
                Console.WriteLine(devCopy.GetDetails());

                Typist typist = new Typist();
                typist.Name = "Mary";
                typist.Role = "Typist";
                typist.WordsPerMinute = 120;

                Typist typistCopy = (Typist)typist.Clone();
                typistCopy.Name = "Sarah";
                typistCopy.WordsPerMinute = 115;//Not mention Role, it will copy above

                Console.WriteLine(typist.GetDetails());
                Console.WriteLine(typistCopy.GetDetails());

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
