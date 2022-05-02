using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement
{
    internal class StandardAcc : Account
    {
        private Print Print = new Print();
        

        public StandardAcc(string iban, decimal overDraft, EnumAccType accType)
            :base(iban,accType)
        {
            base.OverDraft = overDraft;
        }

        public override void PaymentMinus(decimal amount, DateTime localTime, string Description)
        {
            if (amount > 0)
            {
                if ((AccountBalance + OverDraft) >= amount)
                {
                    AccountBalance = AccountBalance - amount;
                    SetHistory(localTime, Description);
                }
                else
                {
                    Print.PrintMsg(EnumPrintId.IssufientBalance, EnumColors.Red);
                }
            }
            else
            {
                Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
            }            
        }

        public void OverDraftChange(decimal newOverdraft) 
        {
            OverDraft = newOverdraft;
        }


    }
}
