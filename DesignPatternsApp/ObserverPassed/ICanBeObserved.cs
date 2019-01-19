using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPassed
{
    //NOTE: this lives outside of the interface
    public delegate void SomethingAmazingJustHappenedHandler(object sender, SomethingAmazingEventArgs e);

    public interface ICanBeObserved
    {
        //this is the name of the 'broadcasting' method
        event SomethingAmazingJustHappenedHandler OnSomethingAmazingJustHappened;

        //this has nothing to do with observables, just regular 'ol biz logic
        void DoSomethingAmazing();
    }
}
