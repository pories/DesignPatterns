using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public class Client
    {
        public void BuildAndInterpretCommands()
        {
            Context context = new Context("The real context");
            NonterminalExpression root = new NonterminalExpression();
            root.Expression1 = new TerminalExpression();
            root.Expression2 = new TerminalExpression();
            root.Interpret(context);
        }
    }
}
