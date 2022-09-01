using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.ConcreteLoans
{
    public class OverdraftLoans : Loans
    {
        public Item Collateral { get; protected set; }

        public Bank BankAccount { get; protected set; }

        public OverdraftLoans(double amount, double loanTerm, User user, Bank bank, Item collateral)
        {
            Amount = amount;
            LoanTerm = loanTerm;
            RequiredIncome = 5000;
            User = user;
            BankAccount = bank;
            Collateral = collateral;
        }

        public OverdraftLoans(double amount, double loanTerm, User user, Bank bank)
        {
            Amount = amount;
            LoanTerm = loanTerm;
            RequiredIncome = 5000;
            User = user;
            BankAccount = bank;
            Collateral = null;
        }

        //public override void SetLiability(double m)
        //{
        //    this.Liability = m;
        //}

        public override string ToString()
        {
            return $"An Overdraft Loan Package with{base.ToString()}. {(Collateral != null ? "Have a Collateral:" + Collateral : "No Collateral")}.";
        }
    }
}