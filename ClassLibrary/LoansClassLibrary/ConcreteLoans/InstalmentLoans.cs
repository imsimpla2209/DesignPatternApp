using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.ConcreteLoans
{
    public class InstalmentLoans : Loans
    {
        public Item Item { get; protected set; }
        public double Prepayment { get; protected set; }

        public InstalmentLoans(double amount, double loanTerm, Item item, User user)
        {
            Amount = amount;
            LoanTerm = loanTerm;
            RequiredIncome = 6000;
            User = user;
            Item = item;
        }

        //public override void SetLiability(double m)
        //{
        //    this.Liability = m;
        //}

        public void SetPrepayment(double P)
        {
            Prepayment = P;
        }

        public override string ToString()
        {
            return $"An Intalment Loan Package with {base.ToString()}. The Item: {Item}, Prepayment: {Prepayment}.";
        }
    }
}