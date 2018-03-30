using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNull
{
    public class HRForm : ISpreadsheet 
    {
        public void open()
        {
            Console.WriteLine("Working on the HR form.");
        }
    }
}
