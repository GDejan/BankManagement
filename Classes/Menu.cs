using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Classes;
using static BankManagement.Enumerators;

namespace BankManagement
{
    internal class Menu
    {
        private Print Print = new Print();
        private SessionAccount sessionAccount;
        private Checks Checks = new Checks();

        public Menu(SessionAccount sessionAccount)
        {
            this.sessionAccount = sessionAccount;
            do
            {
                Print.PrintHeader(sessionAccount);
                Print.PrintMsg(EnumPrintId.PrintMenu, EnumColors.White);
                OpSelection(Console.ReadLine());

            } while ((sessionAccount.IsActiv));
        }

        private void OpSelection(string selection)
        {
            DateTime localTime = DateTime.Now;
            Console.Clear();
            Print.PrintHeader(sessionAccount);
            decimal amount;
            switch (selection)
            {
                case "1":
                    Print.PrintMsg(EnumPrintId.BalanceHeader, EnumColors.White);
                    Print.PrintAccBalance(sessionAccount.Account.Balance(), sessionAccount.Account.OverDraft, EnumColors.White);
                    exitSwitch();
                    break;
                case "2":
                    Print.PrintMsg(EnumPrintId.HistoryHeader, EnumColors.White);
                    sessionAccount.Account.GetHistory();
                    exitSwitch();
                    break;
                case "3":
                    do
                    {
                        Print.PrintMsg(EnumPrintId.PlusAmount, EnumColors.White);
                        amount = Checks.CheckAmount(Console.ReadLine());
                    } while (amount<0);

                    sessionAccount.Account.PaymentPlus(amount, localTime, Print.GetStringPaymentPlus(amount));
                    Print.PrintAccBalance(sessionAccount.Account.Balance(), sessionAccount.Account.OverDraft, EnumColors.White);
                    exitSwitch();
                    break;
                case "4":
                    do
                    {
                        Print.PrintMsg(EnumPrintId.MinusAmount, EnumColors.White);
                        amount = Checks.CheckAmount(Console.ReadLine());
                    } while (amount < 0);

                    sessionAccount.Account.PaymentMinus(amount, localTime, Print.GetStringPaymentMinus(amount));
                    Print.PrintAccBalance(sessionAccount.Account.Balance(), sessionAccount.Account.OverDraft,EnumColors.White);
                    exitSwitch();
                    break;
                case "5":
                    if (new Exit(EnumExit.Menu).ReturnBool)
                    {
                        sessionAccount.IsActiv = false;
                    }else 
                    {
                        sessionAccount.IsActiv = true;
                    }
                    break;
                default:
                    Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
                    Print.PrintMsg(EnumPrintId.PressEnter, EnumColors.White);
                    Console.ReadLine();
                    break;
            }
        }
        private void exitSwitch()
        {
            Print.PrintMsg(EnumPrintId.EndHeader, EnumColors.White);
            Print.PrintMsg(EnumPrintId.PressEnter, EnumColors.White);
            Console.ReadLine();
        }
    }
}
