using LoansClassLibrary.CalculatingSevice;
using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;
using LoansClassLibrary.PrestigeChecker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.LoansFactory
{
    public class UnsecuredLoansFactory : ILoanFactory
    {
        public Loans CreateLoans(double amount, User user, double loanTerm)
        {
            var Calculator = new LiabilityCalculator();
            var loans = new UnsecuredLoans(amount, user, loanTerm);
            var Liability3 = Calculator.GetLiability(loans);
            loans.SetLiability(Liability3);
            user.SetLoanList(loans);
            return loans;
        }
    }
}