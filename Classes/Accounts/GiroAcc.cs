using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeC3
{
    internal class GiroAcc : Account
    {
        public GiroAcc(string iban, string accType)
            :base(iban, accType)
        {

        }

    }
}
