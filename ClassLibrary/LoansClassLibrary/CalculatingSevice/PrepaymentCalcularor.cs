using LoansClassLibrary.Client;
using LoansClassLibrary.ConcreteLoans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoansClassLibrary.CalculatingSevice
{
    public class PrepaymentCalcularor
    {
        private Item _item;

        public PrepaymentCalcularor(Item item)
        {
            this._item = item;
        }

        public double CalPrepayment()
        {
            return this._item.value * 30.0 / 100;
        }
    }
}