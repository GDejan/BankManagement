using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Classes.Helpers;
using static BankManagement.Enumerators;

namespace BankManagement.Classes
{
    internal class NewAccount
    {
        private Print Print = new Print();
        private Checks Checks = new Checks();
        private UserSelect selection = new UserSelect();
        private string name { get; set; }
        private string surname { get; set; }
        private string oib { get; set; }
        private EnumAccType accountType { get; set; }
        private decimal overDraft;
        private string Iban { get; set; }
        private string companyName { get; set; }


        public NewAccount()
        {
            Print.PrintMsg(EnumPrintId.UserName, EnumColors.White);
            this.name = Console.ReadLine();
            Print.PrintMsg(EnumPrintId.UserSurname, EnumColors.White);
            this.surname = Console.ReadLine();
            Print.PrintMsg(EnumPrintId.UserOib, EnumColors.White);
            this.oib = Console.ReadLine();

            newAccount();
            newUser();
            Print.PrintNewAccInfo(name,surname,oib,accountType,Iban,overDraft,companyName);
        }

        private void newAccount() 
        {
            do
            {
                Print.PrintMsg(EnumPrintId.AccType, EnumColors.White);
                EnumAccType selected = selection.GetUserAccType();

                if (selected == EnumAccType.Ziro)
                {
                    this.accountType = EnumAccType.Ziro;
                    newGiro();
                    break;
                }
                else if (selected == EnumAccType.Tekuci)
                {
                    do
                    {
                        Print.PrintMsg(EnumPrintId.AccOwerdraft, EnumColors.White);
                        overDraft = Checks.CheckAmount(Console.ReadLine());
                    } while (overDraft < 0);
                    this.accountType = EnumAccType.Tekuci;
                    newStandard();
                    break;
                }
                else
                {
                    Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
                    continue;
                }
            } while (true);
        }

        private void newUser()
        {
            do
            {
                Print.PrintMsg(EnumPrintId.IsBussines, EnumColors.White);
                EnumYesNO selected = selection.GetUserYesNo();
                if (selected == EnumYesNO.Da)
                {
                    Print.PrintMsg(EnumPrintId.CompanyName, EnumColors.White);
                    companyName = Console.ReadLine();

                    newBussines(companyName);
                    Print.PrintMsg(EnumPrintId.UserAddedHeader, EnumColors.Green);
                    break;
                }
                else if (selected == EnumYesNO.Ne)
                {
                    newPrivate();
                    Print.PrintMsg(EnumPrintId.UserAddedHeader, EnumColors.Green);
                    break;
                }
                else 
                {
                    Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
                    continue;
                }
            } while (true);          
        }

        private void newPrivate()
        {
            PrivateUser privateAcc = new PrivateUser(name, surname, oib, Iban, EnumUserType.Privatni);
            Database.IbanUser.Add(Iban, privateAcc);
        }
        private void newBussines(string companyName)
        {
            BusinessUser business = new BusinessUser(name, surname, oib, Iban, companyName, EnumUserType.Poslovni);
            Database.IbanUser.Add(Iban, business);
        }

        private void newGiro()
        {
            NewIBAN newIban = new NewIBAN("Z");
            this.Iban = newIban.newIban;
            GiroAcc newGiro = new GiroAcc(Iban, accountType);
            Database.IbanAccount.Add(newIban.newIban, newGiro);
        }

        private void newStandard()
        {
            NewIBAN newIban = new NewIBAN("T");
            this.Iban = newIban.newIban;
            StandardAcc newStandard = new StandardAcc(newIban.newIban, overDraft, accountType);
            Database.IbanAccount.Add(newIban.newIban, newStandard);
        }

    }
}

