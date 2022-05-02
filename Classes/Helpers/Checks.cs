using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement
{
    class Checks
    {
        Print Print = new Print();
        public Users CheckUser(string IBAN, string OIB)
        {
            Users currentUser = null;
            foreach (var item in Database.IbanUser.Where(item => (item.Key.ToLower() == IBAN.ToLower()) && (item.Value.OiB == OIB)))
            {
                return item.Value;
            }
            return null;
        }

        public Account CheckAccount(string IBAN)
        {
            Account currentAccount = null;
            foreach (var item in Database.IbanAccount.Where(item => (item.Key.ToLower() == IBAN.ToLower())))
            {
                return item.Value;
            }
            return null;
        }
        public decimal CheckAmount(string amount)
        {
            try
            {
                if (decimal.Parse(amount)>=0)
                {
                    return decimal.Parse(amount);
                }
                else 
                {
                    Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
                    return -1;
                }
            }
            catch 
            {
                Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
                return -1;
            }
        }
    }
}
