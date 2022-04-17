using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VjezbeC3.Classes;
using static VjezbeC3.Enumerators;

namespace VjezbeC3
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
                Print.PrintMsg(20, EnumColors.White);
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
                    Print.PrintMsg(16, EnumColors.White);
                    Print.PrintAccBalance(sessionAccount.Account.Balance(), EnumColors.White);
                    //Console.WriteLine("Dozvoljeni minus: {0,6:C2}", sessionAccount.Account.overDraft);
                    exitSwitch();
                    break;
                case "2":
                    Print.PrintMsg(13, EnumColors.White);
                    sessionAccount.Account.GetHistory();
                    exitSwitch();
                    break;
                case "3":
                    do
                    {
                        Print.PrintMsg(11, EnumColors.White);
                        amount = Checks.CheckAmount(Console.ReadLine());
                    } while (amount<0);

                    sessionAccount.Account.PaymentPlus(amount, localTime, Print.GetStringPaymentPlus(amount));
                    Print.PrintAccBalance(sessionAccount.Account.Balance(), EnumColors.White);
                    exitSwitch();
                    break;
                case "4":
                    do
                    {
                        Print.PrintMsg(12, EnumColors.White);
                        amount = Checks.CheckAmount(Console.ReadLine());
                    } while (amount < 0);

                    sessionAccount.Account.PaymentMinus(amount, localTime, Print.GetStringPaymentMinus(amount));
                    Print.PrintAccBalance(sessionAccount.Account.Balance(), EnumColors.White);
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
                    Print.PrintMsg(100, EnumColors.Red);
                    Print.PrintMsg(15, EnumColors.White);
                    Console.ReadLine();
                    break;
            }
        }
        private void exitSwitch()
        {
            Print.PrintMsg(14, EnumColors.White);
            Print.PrintMsg(15, EnumColors.White);
            Console.ReadLine();
        }
    }
}
