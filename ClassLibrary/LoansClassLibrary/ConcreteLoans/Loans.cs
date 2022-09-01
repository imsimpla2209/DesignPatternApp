using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.ConcreteLoans
{
    public class Loans
    {
        public double Amount { get; protected set; }
        public double InterestRate { get; protected set; }
        public double RequiredIncome { get; protected set; }
        public double LoanTerm { get; protected set; }
        public User User { get; protected set; }
        public double Liability { get; protected set; }

        protected Loans() { }

        public void SetLiability(double m)
        {
            Liability = m;
        }

        public void SetInterestRate(double i)
        {
            this.InterestRate = i;
        }

        public override string ToString()
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // convert VND format
            string VnDAmount = (this.Amount * 1000).ToString("#,###", cul.NumberFormat);
            string VnDLiability = (this.Liability * 1000).ToString("#,###", cul.NumberFormat);

            return $"Amount: {VnDAmount}VND is signed by {User.Name} and Loan Term: {LoanTerm} months. The Liability is {VnDLiability}VND";
        }
    }
}