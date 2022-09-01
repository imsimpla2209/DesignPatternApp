using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.ConcreteLoans
{
    public class MortgageLoans : Loans
    {
        public Item Collateral { get; protected set; }

        public string Purpose { get; protected set; }

        public MortgageLoans(double amount, double loanTerm, User user, string purpose, Item collateral)
        {
            Amount = amount;
            User = user;
            Purpose = purpose;
            Collateral = collateral;
            LoanTerm = loanTerm;
        }

        //public override void SetLiability(double m)
        //{
        //    this.Liability = m;
        //}

        public void SetRequiredIncome(double r)
        {
            RequiredIncome = r;
        }

        public override string ToString()
        {
            return $"A Mortgage Loan Package with {base.ToString()}. The Collateral is {Collateral} and the purpose is '{Purpose}'";
        }
    }
}