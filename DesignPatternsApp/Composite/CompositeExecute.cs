using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CompositeExecute
    {
        public static void CompositeCommand()
        {
            bool repeat = true;
            while (repeat)
            {

                Employee Mike = new Employee { EmpID = 1, Name = "Mike" };

                Employee Paul = new Employee { EmpID = 2, Name = "Paul" };
                Employee Frank = new Employee { EmpID = 3, Name = "Frank" };

                Mike.AddSubordinate(Paul);
                Mike.AddSubordinate(Frank);

                Employee Mary = new Employee { EmpID = 4, Name = "Mary" };
                Employee Marg = new Employee { EmpID = 5, Name = "Marg" };

                Paul.AddSubordinate(Mary);
                Paul.AddSubordinate(Marg);

                Employee Luke = new Employee { EmpID = 6, Name = "Luke" };
                Employee Mat = new Employee { EmpID = 7, Name = "Mat" };

                Contractor Mark = new Contractor { EmpID = 8, Name = "Mark" };
                Contractor John = new Contractor { EmpID = 9, Name = "John" };

                Frank.AddSubordinate(Luke);
                Frank.AddSubordinate(Mat);
                Frank.AddSubordinate(Mark);
                Frank.AddSubordinate(John);

                Console.WriteLine("EmpID={0}, Name={1}", Mike.EmpID, Mike.Name);

                foreach (Employee manager in Mike)
                {
                    Console.WriteLine("\n EmpID={0}, Name={1}", manager.EmpID, manager.Name);

                    foreach (var employee in manager)
                    {
                        Console.WriteLine(" \t EmpID={0}, Name={1}", employee.EmpID, employee.Name);
                    }
                }

                Console.Write("Go again? Y/N: ");
                string go = Console.ReadLine();
                if (go == "Y" || go == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }

        }
    }
}