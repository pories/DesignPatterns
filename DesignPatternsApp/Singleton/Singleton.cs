using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton myvar1 = null;       
        private Singleton()
        {
            //Nothing goes here. 
        }
        public static Singleton GetInstance()
        {
            if (null == myvar1)
            {
                myvar1 = new Singleton();
            }
            return myvar1;
        }

        public void DoSomething(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
