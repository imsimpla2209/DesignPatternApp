using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.LoansFactory
{
    public interface ILoanFactory
    {
        Loans CreateLoans(double amount, User user, double loanTerm);
    }
}