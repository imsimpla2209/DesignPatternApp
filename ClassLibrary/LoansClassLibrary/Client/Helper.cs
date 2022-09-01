using LoansClassLibrary.CalculatingSevice;
using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.Client
{
    public enum LoanType
    {
        Instalment, Hot, Overdraft, Mortgage, Unsecured
    }

    public class Helper
    {
        public Loans CompleteLoan(LoanType type, Loans loan)
        {
            var IService = new InterestRateImplement();
            var Calculator = new LiabilityCalculator();
            switch (type)
            {
                case LoanType.Instalment:
                    var newLoan = (InstalmentLoans)loan;
                    loan.SetInterestRate(IService.Check(newLoan));
                    var Pre = new PrepaymentCalcularor(newLoan.Item);
                    newLoan.SetPrepayment(Pre.CalPrepayment());
                    var Liability = Calculator.GetLiability(newLoan);
                    newLoan.SetLiability(Liability);
                    return newLoan;

                case LoanType.Overdraft:
                    var loans = (OverdraftLoans)loan;
                    loan.SetInterestRate(IService.Check(loans));
                    var Liability1 = Calculator.GetLiability(loans);
                    loans.SetLiability(Liability1);
                    return loans;

                case LoanType.Mortgage:
                    var loans1 = (MortgageLoans)loan;
                    loan.SetInterestRate(IService.Check(loans1));
                    var Liability2 = Calculator.GetLiability(loans1);
                    loans1.SetLiability(Liability2);
                    return loans1;

                case LoanType.Unsecured:
                    var loans2 = (UnsecuredLoans)loan;
                    var Liability3 = Calculator.GetLiability(loans2);
                    loans2.SetLiability(Liability3);
                    return loans2;

                case LoanType.Hot:
                    var loans3 = (HotLoans)loan;
                    var Liability4 = Calculator.GetLiability(loans3);
                    loans3.SetLiability(Liability4);
                    return loans3;

                default:
                    return null;
            }
        }
    }
}