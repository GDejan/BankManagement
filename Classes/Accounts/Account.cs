using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VjezbeC3.Enumerators;

namespace VjezbeC3
{
    internal abstract class Account
    {
        public string IBAN { get; set; }
        private decimal accountBalance;
        public decimal AccountBalance { get; set; }

        public string accountType { get; private set; }

        private Print Print = new Print();

        private decimal overDraft;

        public decimal OverDraft
        {
            get { return overDraft; }
            set { overDraft = value; }
        }

        public Dictionary<DateTime, string> AccountHistory = new Dictionary<DateTime, string>();

        public Account(string iban, string accType)
        {
            this.IBAN = iban;
            this.accountType = accType;
        }

        public void PaymentPlus(decimal amount, DateTime localTime, string Description)
        {
            if (amount > 0)
            {
                AccountBalance += amount;
                SetHistory(localTime, Description);
            }
            else 
            {
                Print.PrintMsg(100, EnumColors.Red);
            }
        }
        public virtual void PaymentMinus(decimal amount, DateTime localTime, string Description)
        {
            if (amount > 0)
            {
                if (AccountBalance >= amount)
                {
                    AccountBalance = AccountBalance - amount;
                    SetHistory(localTime, Description);
                }
                else
                {
                    Print.PrintMsg(102, EnumColors.Red);
                }
            }
            else 
            {
                Print.PrintMsg(100, EnumColors.Red);
            }
            
        }
        public decimal Balance()
        {
            return AccountBalance;
        }

        public void GetHistory() 
        {
            foreach (var item in AccountHistory)
            {
                Print.PrintTxt(item.ToString(), EnumColors.White);
            }
            Print.PrintAccBalance(AccountBalance, OverDraft, EnumColors.White);
        }

        public void SetHistory(DateTime localTime, string Description) 
        {
            AccountHistory.Add(localTime, Description);
        }
    }
}
