using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.ConcreteLoans
{
    public class HotLoans : Loans
    {
        public HotLoans(double amount, User user, double loanTerm)
        {
            Amount = amount;
            InterestRate = 26;
            RequiredIncome = 0;
            User = user;
            LoanTerm = loanTerm;
        }

        public override string ToString()
        {
            return $"A Hot Loan Package with {base.ToString()}";
        }
    }
}