using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteVisitorB : Visitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("VisitorB visited ElementA : {0}", element.Name);
        }
        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("VisitorB visited ElementB : {0}", element.Title);
        }
    }
}
