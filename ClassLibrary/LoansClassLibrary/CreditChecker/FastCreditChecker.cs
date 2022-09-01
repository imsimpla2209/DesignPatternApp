using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.PrestigeChecker
{
    public class FastCreditChecker : ICreditChecker
    {
        public CreditType CreditCheck(User user)
        {
            if (user.IdentityCard != null && user.Income > 0)
            {
                if (user.Age > 20 && (user.LoanStatus == StatusType.Good || user.LoanStatus == StatusType.Pure))
                {
                    return CreditType.High;
                }
                else if (user.Age >= 16 && (user.LoanStatus == StatusType.Pure || user.LoanStatus == StatusType.Remarkable))
                {
                    return CreditType.Medium;
                }
                else
                {
                    return CreditType.Low;
                }
            }
            return CreditType.Low;
        }
    }
}