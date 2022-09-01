using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.ConcreteLoans
{
    public class UnsecuredLoans : Loans
    {
        public UnsecuredLoans(double amount, User user, double loanTerm)
        {
            Amount = amount;
            InterestRate = 21;
            RequiredIncome = 4000;
            User = user;
            LoanTerm = loanTerm;
        }


        public override string ToString()
        {
            return $"An Unsecured Loan Package with {base.ToString()}";
        }
    }
}