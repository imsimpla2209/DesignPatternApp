using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.CalculatingSevice
{
    public class LiabilityCalculator
    {
        public double GetLiability(Loans loan)
        {
            var liability = loan.Amount + (loan.Amount * (loan.InterestRate * 1.0 / 100) / 12 * loan.LoanTerm);
            return liability;
        }
    }
}