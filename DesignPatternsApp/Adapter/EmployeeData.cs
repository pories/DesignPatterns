using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class EmployeeData : IData
    {
        public string GetQualifiedData()
        {
            EmployeeAdaptee empadp = new EmployeeAdaptee();
            return string.Format("Total: {0} {1}", empadp.ContractEmployeeData(), empadp.FullTimeEmployeeData());
        }
    }
}
