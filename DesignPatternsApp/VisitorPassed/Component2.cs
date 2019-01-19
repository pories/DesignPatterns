using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPassed
{
    public class Component2 : ISaySomething
    {
        public void SaySomething(string message)
        {
            Console.WriteLine($"Hello from {GetType().Name}, a visitor wants me to say: {message}!");
        }
    }
}
