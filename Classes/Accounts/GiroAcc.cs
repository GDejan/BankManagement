using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement
{
    internal class GiroAcc : Account
    {
        public GiroAcc(string iban, EnumAccType accType)
            :base(iban, accType)
        {

        }

    }
}
