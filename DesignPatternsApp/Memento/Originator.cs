using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class Originator
    {
        private string state;

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            this.state = memento.GetState();
        }
    }
}
