using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.PrestigeChecker
{
    public class CheckerService
    {
        public ICreditChecker Checker { get; set; }

        public CheckerService(ICreditChecker checker)
        {
            Checker = checker;
        }

        public CreditType GetPrestige(User user)
        {
            return Checker.CreditCheck(user);
        }
    }
}