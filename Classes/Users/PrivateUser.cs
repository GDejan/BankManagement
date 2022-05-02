using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement
{
    internal class PrivateUser : Users
    {
        public PrivateUser(string name, string surname, string oib, string iban, EnumUserType isPrivate)
            :base(name, surname, oib, iban, isPrivate)
        {
            
        }
    }
}
