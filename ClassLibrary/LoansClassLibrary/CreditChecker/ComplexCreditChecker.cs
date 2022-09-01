using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.PrestigeChecker
{
    public class ComplexCreditChecker : ICreditChecker
    {
        public CreditType CreditCheck(User user)
        {
            if (user.IdentityCard != null && user.Income > 0 && user.Age >= 18)
            {
                if (user.Age > 20 && (user.LoanStatus == StatusType.Good || user.LoanStatus == StatusType.Pure) && user.isHavingJob && user.Income > 7000)
                {
                    return CreditType.High;
                }
                else if (user.LoanStatus == StatusType.Pure && user.isHavingJob && user.Income > 5000)
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