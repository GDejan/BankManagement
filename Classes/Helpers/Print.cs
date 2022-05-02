using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement
{
    internal class Print
    {
        public void PrintMsg(EnumPrintId Msgid, EnumColors EnumColor)
        {
            selectColor(EnumColor);

            switch (Msgid)
            {
                case EnumPrintId.AccIban:
                    Console.Write("Unesite IBAN racuna: ");
                    break;
                case EnumPrintId.UserOib:
                    Console.Write("Unesite OIB korisnika: ");
                    break;
                case EnumPrintId.UserName:
                    Console.Write("Unesite ime korisnika: ");
                    break;
                case EnumPrintId.UserSurname:
                    Console.Write("Unesite prezime korisnika: ");
                    break;
                case EnumPrintId.NewUserYesNo:
                    Console.Write("Zelite kreirati novog korisnika (DA/NE): ");
                    break;
                case EnumPrintId.IsBussines:
                    Console.Write("Poslovni racun (DA/NE): ");
                    break;
                case EnumPrintId.CompanyName:
                    Console.Write("Unesite ime tvrtke: ");
                    break;
                case EnumPrintId.AccType:
                    Console.Write("Tip racuna (tekuci/ziro): ");
                    break;
                case EnumPrintId.AccOwerdraft:
                    Console.Write("Unesite dozvoljeni minus (kn): ");
                    break;
                case EnumPrintId.BalanceAcc:
                    Console.Write("Uplata na racun (tekuci/ziro): ");
                    break;
                case EnumPrintId.PlusAmount:
                    Console.Write("unesite iznos za uplatu (kn): ");
                    break;
                case EnumPrintId.MinusAmount:
                    Console.Write("unesite iznos za isplatu (kn): ");
                    break;
                case EnumPrintId.HistoryHeader:
                    Console.WriteLine("-----------Promet po racunu-----------");
                    break;
                case EnumPrintId.EndHeader:
                    Console.WriteLine("-----------kraj zapisa-----------");
                    break;
                case EnumPrintId.PressEnter:
                    Console.Write("pritisni Enter za povratak na izbornik");
                    break;
                case EnumPrintId.BalanceHeader:
                    Console.WriteLine("-----------stanje racuna-----------");
                    break;
                case EnumPrintId.PrintMenu:
                    Console.WriteLine("-----------Izbornik-----------");
                    Console.WriteLine("1. Stanje racuna");
                    Console.WriteLine("2. Promet po racunu");
                    Console.WriteLine("3. Uplata na racuna");
                    Console.WriteLine("4. Isplata sa racuna");
                    Console.WriteLine("5. Izlaz");
                    Console.Write("Izbor --> ");
                    break;
                case EnumPrintId.AddNewUser:
                    Console.Write("Zeli te li dodati korisnika (DA/NE): ");
                    break;
                case EnumPrintId.NewUserHeader:
                    Console.WriteLine("-----------Novi korisnik-----------");
                    break;
                case EnumPrintId.ExistUser:
                    Console.WriteLine("-----------Postojeci korisnik-----------");
                    break;
                case EnumPrintId.CloseUser:
                    Console.Write("Zatvoriti korisnika (DA/NE): ");
                    break;
                case EnumPrintId.EndApp:
                    Console.Write("Ugasiti aplikaciju (DA/NE): ");
                    break;
                case EnumPrintId.UserAddedHeader:
                    Console.WriteLine("-----------Korisnik dodan-----------");
                    break;
                case EnumPrintId.NewAccountHeader:
                    Console.WriteLine("-----------Racun otvoren-----------");
                    break;
                case EnumPrintId.WrongInput:
                    Console.WriteLine("-----------Pogresan unos-----------");
                    break;
                case EnumPrintId.AccNotFound:
                    Console.WriteLine("-----------Racun nije pronadjen-----------");
                    break;
                case EnumPrintId.IssufientBalance:
                    Console.WriteLine("Nedovoljno sredstva na racunu");
                    break;
                    break;
                case EnumPrintId.ExitHeader:
                    Console.WriteLine("-----------Izlazak-----------");
                    break;
                default:
                    break;
            }
            resetColor();
        }

        public void PrintTxt(string text, EnumColors EnumColor)
        {
            selectColor(EnumColor);
            Console.WriteLine(text);
            resetColor();
        }
        public void PrintAccBalance(decimal amount, decimal overDraft, EnumColors EnumColor)
        {
            selectColor(EnumColor);
            Console.WriteLine("Trenutno stanje je: {0,6:C2}", amount);
            Console.WriteLine("Dozvoljeni minus: {0,6:C2}", overDraft);
            resetColor();
        }

        public string GetStringPaymentPlus(decimal amount) 
        {
            return string.Format("Uplaceno: \t {0,6:C2} \tuplatitelj: {1}", amount, Environment.UserName);
        }
        public string GetStringPaymentMinus(decimal amount)
        {
            return string.Format("Isplaceno:\t-{0,6:C2} \tisplatitelj: {1}", amount, Environment.UserName);
        }

        public void PrintHeader(SessionAccount sessionAccount)
        {
            Console.Clear();
            Console.WriteLine("-----------{0}-----------", sessionAccount.User.FullName());
            Console.WriteLine("- Tip: {0} ", sessionAccount.User.IsPrivate.ToString());
            Console.WriteLine("- IBAN: {0} ", sessionAccount.User.IBAN);
            Console.WriteLine("- Racun: {0} ", sessionAccount.Account.accountType);
            Console.WriteLine("--------------------------------");
        }

        public void PrintNewAccInfo(string name, string surname, string oib, EnumAccType accountType, string Iban, decimal overDraft, string companyName)
        {
            Console.Clear();
            PrintMsg(EnumPrintId.UserAddedHeader, EnumColors.Green);
            PrintMsg(EnumPrintId.NewAccountHeader, EnumColors.Green);
            Console.WriteLine("Ime korisnika: {0}", name);
            Console.WriteLine("Prezime korisnika: {0}", surname);
            Console.WriteLine("Oib korisnika: {0}", oib);
            Console.WriteLine("Tip racuna: {0}", accountType);
            Console.WriteLine("IBAN racuna: {0}", Iban);
            Console.WriteLine("Prekoracenje: {0,6:C}", overDraft);
            Console.WriteLine("Ime tvrtke: {0}", companyName);
        }

        private static void selectColor(EnumColors EnumColor)
        {
            if (EnumColor == EnumColors.Red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (EnumColor == EnumColors.Green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (EnumColor == EnumColors.White)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        private static void resetColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}

