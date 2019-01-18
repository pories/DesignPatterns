using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class ChainOfResponsibilityExecute
    {
        public static void ChainOfResponsibilityCommand()
        {
            bool repeat = true;
            while (repeat)
            {
                Approver Mike = new Clerk();
                Approver Paul = new AssistantManager();
                Approver Frank = new Manager();

                Mike.Successor = Paul;
                Paul.Successor = Frank;

                // Generate and process loan requests
                var loan = new Loan { Number = 2034, Amount = 24000.00, Purpose = "Laptop Loan" };
                Mike.ProcessRequest(loan);

                loan = new Loan { Number = 2035, Amount = 42000.10, Purpose = "Bike Loan" };
                Mike.ProcessRequest(loan);

                loan = new Loan { Number = 2036, Amount = 156200.00, Purpose = "House Loan" };
                Mike.ProcessRequest(loan);

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