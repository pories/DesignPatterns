using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public class ConcreteClassA : AbstractClass
    {
        public override void Step1()
        {
            Console.WriteLine("Concrete Class A, Step 1");
        }

        public override void Step2()
        {
            Console.WriteLine("Concrete Class A, Step 2");
        }

        public override void Step3()
        {
            Console.WriteLine("Concrete Class A, Step 3");
        }
    }
}
