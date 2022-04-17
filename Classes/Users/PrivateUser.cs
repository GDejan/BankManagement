using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeC3
{
    internal class PrivateUser : Users
    {
        public PrivateUser(string name, string surname, string oib, string iban, bool isPrivate)
            :base(name, surname, oib, iban, isPrivate)
        {
            
        }
    }
}
