using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPassed
{
    public interface IFoo : IVisitable
    {
        Component2 Component2 { get; }
        Component3 Component3 { get; }
    }
}
