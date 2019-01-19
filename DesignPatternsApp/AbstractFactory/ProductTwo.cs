using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //a generic model that implements IProduct
    public class ProductTwo : IProduct
    {
        public void MyMethod()
        {
            Console.WriteLine("Invoking method from product 2!");
        }
    }
}
