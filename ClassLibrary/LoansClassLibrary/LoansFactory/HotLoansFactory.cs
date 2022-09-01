using LoansClassLibrary.CalculatingSevice;
using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.LoansFactory
{
    public class HotLoansFactory : ILoanFactory
    {
        public Loans CreateLoans(double amount, User user, double loanTerm)
        {
            var Calculator = new LiabilityCalculator();
            var loans = new HotLoans(amount, user, loanTerm);
            var Liability4 = Calculator.GetLiability(loans);
            loans.SetLiability(Liability4);
            user.SetLoanList(loans);
            return loans;
        }
    }
}