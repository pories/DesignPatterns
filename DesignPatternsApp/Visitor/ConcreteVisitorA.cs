using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class ConcreteVisitorA : Visitor
    {
        public void Visit(ConcreteElementA element)
        {
            Console.WriteLine("VisitorA visited ElementA : {0}", element.Name);
        }
        public void Visit(ConcreteElementB element)
        {
            Console.WriteLine("VisitorA visited ElementB : {0}", element.Title);
        }
    }
}
