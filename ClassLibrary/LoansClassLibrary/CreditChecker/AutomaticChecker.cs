using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.PrestigeChecker
{
    public class AutomaticChecker
    {
        private User _user;

        public AutomaticChecker(User user)
        {
            _user = user;
        }

        public CreditType GetFastCredit()
        {
            var GetChecker = new FastCreditChecker();
            var Checker = new CheckerService(GetChecker);
            return Checker.GetPrestige(_user);
        }

        public CreditType GetCarefullCredit()
        {
            var GetChecker = new ComplexCreditChecker();
            var Checker = new CheckerService(GetChecker);
            return Checker.GetPrestige(_user);
        }
    }
}