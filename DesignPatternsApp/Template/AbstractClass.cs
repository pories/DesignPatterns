using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template
{
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }
        public abstract void Step1();

        public abstract void Step2();

        public abstract void Step3();
    }
}
