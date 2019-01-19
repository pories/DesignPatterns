using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPassed
{
    public interface IIterator
    {
        //Could use generic type, or generics. 
        //Customizable to what you need. 
        void First(); //Reset back to first element.
        string Next(); //Get Next.
        bool IsDone(); // End of collection check.
        string CurrentItem(); //Get current item. 
    }
}
