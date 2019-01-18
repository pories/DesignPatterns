﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// The 'ConcreteHandler' class
    class Clerk : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs e)
        {
            if (e.Loan.Amount < 25000.0)
            {
                Console.WriteLine("{0} approved request# {1}",
                this.GetType().Name, e.Loan.Number);
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, e);
            }
        }
    }
}
