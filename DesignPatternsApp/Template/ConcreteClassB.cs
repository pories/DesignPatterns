using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class ConcreteClassB : AbstractClass
    {
        public override void Step1()
        {
            Console.WriteLine("Concrete Class B, Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Concrete Class B, Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Concrete Class B, Step 3");
        }
    }
}
