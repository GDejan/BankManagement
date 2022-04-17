using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeC3.Classes.Accounts
{
    internal interface IAccount
    {
        void PaymentPlus(decimal amount, DateTime localTime, string Description);
        void PaymentMinus(decimal amount, DateTime localTime, string Description);
        decimal Balance();
        void GetHistory();
    }
}
