using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static VjezbeC3.Enumerators;

namespace VjezbeC3
{
    internal class Print
    {
        public void PrintMsg(int Msgid, EnumColors EnumColor)
        {
            selectColor(EnumColor);

            switch (Msgid)
            {
                case 1:
                    Console.Write("Unesite IBAN racuna: ");
                    break;
                case 2:
                    Console.Write("Unesite OIB korisnika: ");
                    break;
                case 3:
                    Console.Write("Unesite ime korisnika: ");
                    break;
                case 4:
                    Console.Write("Unesite prezime korisnika: ");
                    break;
                case 5:
                    Console.Write("Zelite kreirati novog korisnika (DA/NE): ");
                    break;
                case 6:
                    Console.Write("Poslovni racun (DA/NE): ");
                    break;
                case 7:
                    Console.Write("Unesite ime tvrtke: ");
                    break;
                case 8:
                    Console.Write("Tip racuna (tekuci/ziro): ");
                    break;
                case 9:
                    Console.Write("Unesite dozvoljeni minus (kn): ");
                    break;
                case 10:
                    Console.Write("Uplata na racun (tekuci/ziro): ");
                    break;
                case 11:
                    Console.Write("unesite iznos za uplatu (kn): ");
                    break;
                case 12:
                    Console.Write("unesite iznos za isplatu (kn): ");
                    break;
                case 13:
                    Console.WriteLine("-----------Promet po racunu-----------");
                    break;
                case 14:
                    Console.WriteLine("-----------kraj zapisa-----------");
                    break;
                case 15:
                    Console.Write("pritisni Enter za povratak na izbornik");
                    break;
                case 16:
                    Console.WriteLine("-----------stanje racuna-----------");
                    break;
                case 20:
                    Console.WriteLine("-----------Izbornik-----------");
                    Console.WriteLine("1. Stanje racuna");
                    Console.WriteLine("2. Promet po racunu");
                    Console.WriteLine("3. Uplata na racuna");
                    Console.WriteLine("4. Isplata sa racuna");
                    Console.WriteLine("5. Izlaz");
                    Console.Write("Izbor --> ");
                    break;
                case 30:
                    Console.Write("Zeli te li dodati korisnika (DA/NE): ");
                    break;
                case 31:
                    Console.WriteLine("-----------Novi korisnik-----------");
                    break;
                case 32:
                    Console.WriteLine("-----------Postojeci korisnik-----------");
                    break;
                case 48:
                    Console.Write("Zatvoriti korisnika (DA/NE): ");
                    break;
                case 49:
                    Console.Write("Ugasiti aplikaciju (DA/NE): ");
                    break;
                case 50:
                    Console.WriteLine("-----------Korisnik dodan-----------");
                    break;
                case 51:
                    Console.WriteLine("-----------Racun otvoren-----------");
                    break;
                case 100:
                    Console.WriteLine("-----------Pogresan unos-----------");
                    break;
                case 101:
                    Console.WriteLine("-----------Racun nije pronadjen-----------");
                    break;
                case 102:
                    Console.WriteLine("Nedovoljno sredstva na racunu");
                    break;
                    break;
                case 110:
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
        public void PrintAccBalance(decimal amount, EnumColors EnumColor)
        {
            selectColor(EnumColor);
            Console.WriteLine("Trenutno stanje je: {0,6:C2}", amount);
            resetColor();
        }

        public string GetStringPaymentPlus(decimal amount) 
        {
            return string.Format("Uplaceno: \t {0,6:C2} \tuplatitelj: {1}", amount, System.Security.Principal.WindowsIdentity.GetCurrent().Name);
        }
        public string GetStringPaymentMinus(decimal amount)
        {
            return string.Format("Isplaceno:\t-{0,6:C2} \tisplatitelj: {1}", amount, System.Security.Principal.WindowsIdentity.GetCurrent().Name);
        }

        public void PrintHeader(SessionAccount sessionAccount)
        {
            Console.Clear();
            Console.WriteLine("-----------{0}-----------", sessionAccount.User.FullName());
            Console.WriteLine("- Privatni: {0} ", sessionAccount.User.IsPrivate);
            Console.WriteLine("- IBAN: {0} ", sessionAccount.User.IBAN);
            Console.WriteLine("- Racun: {0} ", sessionAccount.Account.accountType);
            Console.WriteLine("--------------------------------");
        }

        public void PrintNewAccInfo(string name, string surname, string oib, string accountType, string Iban, decimal overDraft, string companyName)
        {
            Console.Clear();
            PrintMsg(50, EnumColors.Green);
            PrintMsg(51, EnumColors.Green);
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
            if ((int)EnumColor == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if ((int)EnumColor == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if ((int)EnumColor == 0)
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

