using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdapterExe
    {
        public static void Execute()
        {
            ManagersData md = new ManagersData();
            Console.WriteLine(md.GetQualifiedData());
            EmployeeData emplo = new EmployeeData();
            emplo.GetQualifiedData();
            Console.ReadLine();
        }
    }
}
