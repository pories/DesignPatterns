using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPassed
{
    public class IteratorPassedExecute
    {
        public static void IteratorPassedCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                //Due to so many types of collections.
                ISocialNetworking fb = new Facebook();
                ISocialNetworking tw = new Twitter();

                IIterator fbIterator = fb.CreateIterator();
                IIterator twIterator = tw.CreateIterator();

                Console.WriteLine("Facebook: ");
                PrintUsers(fbIterator);
                Console.WriteLine("      ");
                Console.WriteLine("Twitter: ");
                PrintUsers(twIterator);
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
        public static void PrintUsers(IIterator iterate)
        {
            iterate.First();
            while (!iterate.IsDone())
            {
                Console.WriteLine(iterate.Next());
            }
        }
    }
}
