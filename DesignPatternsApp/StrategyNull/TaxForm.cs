using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNull
{
    public class TaxForm : ISpreadsheet
    {
        public void open()
        {
            Console.WriteLine("Working on the tax form.");
        }
    }
}
