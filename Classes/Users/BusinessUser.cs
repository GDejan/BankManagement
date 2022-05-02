using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement
{
    internal class BusinessUser : Users
    {
        public string CompanyName { get; set; }
        public BusinessUser(string name, string surname, string oib, string iban, string companyName, EnumUserType isPrivate)
            :base(name, surname, oib, iban, isPrivate)
        {
            this.CompanyName = companyName;
        }
    }
}
