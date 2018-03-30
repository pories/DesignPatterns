using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNull
{
    public class Null : ISpreadsheet 
    {
        public void open()
        {           
            Console.WriteLine("Not a listed option.");
        }
    }
}