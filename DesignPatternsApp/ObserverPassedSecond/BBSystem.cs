using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPassedSecond
{
    public class BBSystem
    {
        //this is the subject!
        // must add using statement for folders if you use them
        //aka // must add using statement for ObserverPattapp.Observer;
        private IList<ISubscriber> subscriber = new List<ISubscriber>();

        //colllection of observers.
        public void subscribe(ISubscriber s)
        {
            subscriber.Add(s);
        }
        public void unsubscribe(ISubscriber s)
        {
            subscriber.Remove(s);
        }
        public void notifysubscribers()
        {
            foreach (ISubscriber s in subscriber)
            {
                s.Notify();
            }

        }
    }
}
