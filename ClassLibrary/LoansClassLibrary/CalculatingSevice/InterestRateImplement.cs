using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.CalculatingSevice
{
    public class InterestRateImplement
    {
        public double Check(InstalmentLoans loans)
        {
            var IR = 0.0;
            if (loans.LoanTerm <= 12)
            {
                IR += 8.9;
            }
            else
            {
                var left = (loans.LoanTerm - 12) >= 12;
                if (left) IR = (8.9 + 9.5) / 2;
                else IR = 9.0;
            }
            return IR;
        }

        public double Check(MortgageLoans loans)
        {
            if (loans.Collateral.Document != false)
            {
                return 22;
            }
            else
            {
                return 9;
            }
        }

        public double Check(OverdraftLoans loans)
        {
            if (loans.Collateral != null)
            {
                return 13;
            }
            else
            {
                return 17;
            }
        }
    }
}