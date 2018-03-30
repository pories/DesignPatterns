using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNull
{
    public class Owner
    {        
        private ISpreadsheet myvar1;       
        public void SetSpreadsheet(ISpreadsheet DifferentSpreadSheet)
        {
            myvar1 = DifferentSpreadSheet;
        }   
        public void WorkOn()
        {
            myvar1.open();
        }
    }
}
