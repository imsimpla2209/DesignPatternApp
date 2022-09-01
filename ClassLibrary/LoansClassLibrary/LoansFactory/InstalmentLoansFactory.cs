using LoansClassLibrary.CalculatingSevice;
using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;

namespace LoansClassLibrary.LoansFactory
{
    public class InstalmentLoansFactory : ILoanFactory
    {
        public Loans CreateLoans(double amount, User user, double loanTerm)
        {
            return CreateLoans(0, user, 0, null);
        }

        public Loans CreateLoans(double amount, User user, double loanTerm, Item _item)
        {
            var loans = new InstalmentLoans(amount, loanTerm, _item, user);
            var IService = new InterestRateImplement();
            var Calculator = new LiabilityCalculator();
            loans.SetInterestRate(IService.Check(loans));
            var Pre = new PrepaymentCalcularor(loans.Item);
            loans.SetPrepayment(Pre.CalPrepayment());
            var Liability = Calculator.GetLiability(loans);
            loans.SetLiability(Liability);
            user.SetLoanList(loans);
            return loans;
        }
    }
}


