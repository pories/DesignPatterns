using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNull
{
    public class BalanceSheetForm : ISpreadsheet 
    {
        public void open()
        {
            Console.WriteLine("Working on the balance sheet.");
        }
    }
}
