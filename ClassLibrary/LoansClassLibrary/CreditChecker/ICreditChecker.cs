using LoansClassLibrary.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.PrestigeChecker
{
    public interface ICreditChecker
    {
        CreditType CreditCheck(User user);
    }
}