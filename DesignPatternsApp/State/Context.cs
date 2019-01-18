using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class Context
    {
        private IState state;

        public Context(IState newstate)
        {
            state = newstate;
        }

        public void Request()
        {
            state.Handle(this);
        }

        public IState State
        {
            get { return state; }
            set { state = value; }
        }
    }
}
