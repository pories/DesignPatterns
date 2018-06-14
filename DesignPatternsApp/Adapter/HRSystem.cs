using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class HRSystem
    {
        public string[][] GetEmployees()
        {
            //This is an array of arrays. The first array number is the number of arrays, the second array delaration says that it can store multiple sized arrays. In this case each one is equal and has 3 elements.

            string[][] employees = new string[4][];

            employees[0] = new string[] { "100", "Mike", "Team Leader" };
            employees[1] = new string[] { "101", "John", "Developer" };
            employees[2] = new string[] { "102", "Pat", "Developer" };
            employees[3] = new string[] { "103", "Mary", "Tester" };

            return employees;
        }


    }
}
