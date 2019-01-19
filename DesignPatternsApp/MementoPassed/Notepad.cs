using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPassed
{
    class Notepad
    {   //originator
        private string _text;

        public Memento SetText(string text)
        {
            Memento me = new Memento(_text);
            _text = text;
            return me;
        }

        public string GetText()
        {
            return _text;
        }
        public void UnDo(Memento previousState)
        {
            _text = previousState.GetText();
        }
    }
}
