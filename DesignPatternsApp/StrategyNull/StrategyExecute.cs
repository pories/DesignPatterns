using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyNull
{
    public class StrategyExecute
    {
        public static void StrategyCommand()
        {
            ISpreadsheet spreadsheet = null;
            Owner Mike = new Owner();
            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("This is the strategy pattern. It allows algorithms to be selected at runtime.");
                Console.WriteLine("Enter in a document to work on: 1)Balance Sheet 2) Tax form 3)HR Form. ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        spreadsheet = new BalanceSheetForm();
                        break;

                    case "2":
                        spreadsheet = new TaxForm();
                        break;
                    case "3":
                        spreadsheet = new HRForm();
                        break;

                    default:
                        spreadsheet = new Null();
                        break;
                }
                Mike.SetSpreadsheet(spreadsheet);
                Mike.WorkOn();

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