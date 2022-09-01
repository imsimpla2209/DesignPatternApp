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
    public class MortgageLoansFactory : ILoanFactory
    {
        public Loans CreateLoans(double amount, User user, double loanTerm)
        {
            return null;
        }

        public Loans CreateLoans(double amount, User user, double loanTerm, Item collateral, string purpose)
        {
            var IService = new InterestRateImplement();
            var Calculator = new LiabilityCalculator();
            var loans = new MortgageLoans(amount, loanTerm, user, purpose, collateral);
            loans.SetInterestRate(IService.Check(loans));
            var Liability2 = Calculator.GetLiability(loans);
            loans.SetLiability(Liability2);
            user.SetLoanList(loans);
            return loans;
        }
    }
}