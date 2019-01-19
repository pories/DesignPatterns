using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPassedSecond
{
    public interface ISubscriber
    {
        void Notify();
    }
}
