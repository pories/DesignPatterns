using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class ConcreteStateA : IState
    {
        public void Handle(Context context)
        {
            Console.WriteLine("Handle called from ConcreteStateA");
            context.State = new ConcreteStateB();
        }
    }
}
