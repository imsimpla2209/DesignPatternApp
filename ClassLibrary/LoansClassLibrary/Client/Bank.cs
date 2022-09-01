using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.Client
{
    public class Bank
    {
        public string Name { get; protected set; }
        public string CardNumber { get; protected set; }
        public string ExpiredDate { get; protected set; }
        public double Balance { get; protected set; }

        public Bank(string name, string cardNumber, string expiredDate)
        {
            Name = name;
            CardNumber = cardNumber;
            ExpiredDate = expiredDate;
            Balance = randomBalance();
        }

        public void ReceiveMoney(double money)
        {
            this.Balance += money;
        }

        public void PayMoney(double money)
        {
            this.Balance -= money;
        }

        private double randomBalance()
        {
            var rnd = new Random();
            return rnd.Next(25000000, 600000000) * 1.0;
        }

        public override string ToString()
        {
            CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");   // convert VND format
            string VnDBalance = (this.Balance).ToString("#,###", cul.NumberFormat);
            return $"\n   Name: {Name}\n   Card Number: {CardNumber}\n   Expired Date: {ExpiredDate}\n   Current Balance: {VnDBalance} VND";
        }
    }
}