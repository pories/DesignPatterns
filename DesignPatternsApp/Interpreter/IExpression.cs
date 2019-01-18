using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public interface IExpression
    {
        void Interpret(Context context);
    }

    public class TerminalExpression : IExpression
    {
        public void Interpret(Context context)
        {
            Console.WriteLine("Terminal for {0}.", context.Name);
        }
    }
}
