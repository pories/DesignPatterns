using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ProductOne : IProduct
    {
        public void MyMethod()
        {
            Console.WriteLine("Invoking method from product 1!");
        }
    }
}
