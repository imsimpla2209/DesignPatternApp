using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.Client
{
    public class User
    {
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public string IdentityCard { get; protected set; }
        public Bank BankAccount { get; protected set; }
        public StatusType LoanStatus { get; protected set; }
        public double Income { get; protected set; }
        public bool isHavingJob { get; protected set; }
        public List<Loans> LoanLists { get; protected set; } = new List<Loans>();

        public User(string name, int age, string identityCard, Bank bankAccount, double income, bool isHavingJob)
        {
            Name = name;
            Age = age;
            IdentityCard = identityCard;
            BankAccount = bankAccount;
            LoanStatus = GetLoanStatus();
            Income = income;
            this.isHavingJob = isHavingJob;
        }

        public User(string name, int age, string identityCard, double income, bool isHavingJob)
        {
            Name = name;
            Age = age;
            IdentityCard = identityCard;
            BankAccount = null;
            LoanStatus = GetLoanStatus();
            Income = income;
            this.isHavingJob = isHavingJob;
        }

        internal StatusType GetLoanStatus()
        {
            //var rnd = new Random();
            //return (StatusType)rnd.Next(StatusType.GetNames(typeof(StatusType)).Length);
            return StatusType.Good;
        }

        public void SetLoanStatus(StatusType type)
        {
            this.LoanStatus = type;
        }

        //Loans List
        public string GetLoanList()
        {
            var ListInfo = "Loan List:\n";

            LoanLists.ForEach(L => ListInfo += "~ " + L + "\n");
            return ListInfo;
        }

        public void SetLoanList(Loans loan)
        {
            LoanLists.Add(loan);
        }

        public void RemoveLoanList(int index)
        {
            LoanLists.RemoveAt(index);
        }

        //>>>>>>>>>>>>>

        public Loans GetLoans(int index)
        {
            return LoanLists[index];
        }

        public override string ToString()
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // convert VND format
            string VnDIncome = (1000 * this.Income).ToString("#,###", cul.NumberFormat);
            return $"|Name: {Name}\n|Age: {Age}\n|Identity Card Number: {IdentityCard}\n|Bank Account: {(BankAccount == null ? "Nope" : BankAccount.ToString())}\n|Monthly Income: {VnDIncome} VND\n|Job: {(this.isHavingJob ? "Already Had a job" : "Not Yet or Freelancer")}\n|Loan History Status: {LoanStatus}\n";
        }
    }
}