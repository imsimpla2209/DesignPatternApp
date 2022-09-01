using LoansClassLibrary.CalculatingSevice;
using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;
using LoansClassLibrary.LoansFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestLoans
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var Bankss = new Bank("Nguyen Van Yeah", "2136654987623", "22/07/1689");
            var newMan = new User("Van yeah", 22, "135642335975222", Bankss, 6000, true);

            Console.WriteLine(newMan + "\n");
            var Item = new Item("aksod", 500000);

            var NewLoans = new InstalmentLoansFactory();
            Loans Loan = NewLoans.CreateLoans(50000, newMan, 6, Item);
            var SecondLoans = new OverdraftLoansFactory();
            Loans Loan1 = SecondLoans.CreateLoans(90000, newMan, 12, newMan.BankAccount, Item);
            var thirdLoans = new MortgageLoansFactory();
            Loans Loan2 = thirdLoans.CreateLoans(220000, newMan, 12, Item, "Smoke Weed Get high");
            Console.WriteLine(newMan.GetLoanList());
            Console.Read();
        }
    }
}