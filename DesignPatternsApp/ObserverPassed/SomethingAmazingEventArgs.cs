using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPassed
{
    //NOTE: the inheritance of EventArgs
    public class SomethingAmazingEventArgs : EventArgs
    {
        public int NumberOfUnicornsDancing { get; set; }
        public int BubbleFactor { get; set; }

        //create a constructor with anything you want any observers to know about this amazing event
        public SomethingAmazingEventArgs(int numberOfUnicornsDancing, int bubbleFactor)
        {
            NumberOfUnicornsDancing = numberOfUnicornsDancing;
            BubbleFactor = bubbleFactor;
        }
    }
}
