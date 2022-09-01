using LoansClassLibrary.CalculatingSevice;
using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;

namespace LoansClassLibrary.LoansFactory
{
    public class OverdraftLoansFactory : ILoanFactory
    {
        public Loans CreateLoans(double amount, User user, double loanTerm)
        {
            return null;
        }

        public Loans CreateLoans(double amount, User user, double loanTerm, Bank bank)
        {
            var IService = new InterestRateImplement();
            var Calculator = new LiabilityCalculator();
            var loans = new OverdraftLoans(amount, loanTerm, user, bank);
            loans.SetInterestRate(IService.Check(loans));
            var Liability1 = Calculator.GetLiability(loans);
            loans.SetLiability(Liability1);
            user.SetLoanList(loans);
            return loans;
        }

        public Loans CreateLoans(double amount, User user, double loanTerm, Bank bank, Item collateral)
        {
            var IService = new InterestRateImplement();
            var Calculator = new LiabilityCalculator();
            var loans = new OverdraftLoans(amount, loanTerm, user, bank, collateral);
            loans.SetInterestRate(IService.Check(loans));
            var Liability1 = Calculator.GetLiability(loans);
            loans.SetLiability(Liability1);
            user.SetLoanList(loans);
            return loans;
        }
    }
}

