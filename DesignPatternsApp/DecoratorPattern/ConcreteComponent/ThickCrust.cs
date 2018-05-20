using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    public class ThickCrust : Pizza
    {
        public override double cost()
        {
            return 15;
        }
    }
}