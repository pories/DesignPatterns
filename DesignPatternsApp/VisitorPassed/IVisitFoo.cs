using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPassed
{
    public interface IVisitFoo
    {
        void Visit(IFoo foo);
        void Visit(Component1 component1);
    }
}
