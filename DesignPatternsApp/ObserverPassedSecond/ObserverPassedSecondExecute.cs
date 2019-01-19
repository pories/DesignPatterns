using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPassedSecond
{
    public class ObserverPassedSecondExecute
    {
        public static void ObserverPassedSecondCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                //you recieve updates from an object. Object maintains a list of dependences, called observers. 
                //keeps people updated on subject of interest. 
                BBSystem mike = new BBSystem();

                ISubscriber dave = new User(); //user
                ISubscriber Paul = new User(); //user
                ISubscriber John = new User(); //user
                ISubscriber Ringo = new Moderator(); //Moderator

                mike.subscribe(dave);
                mike.subscribe(Paul);
                mike.subscribe(John);
                mike.subscribe(Ringo);
                Console.WriteLine("Now we notify people that there are 3 people subscribed.");
                mike.notifysubscribers(); //you do some bbsing!!

                Console.WriteLine("Dave unsubscribed");
                mike.unsubscribe(dave);
                mike.notifysubscribers();
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
