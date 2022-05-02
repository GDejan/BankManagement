using BankManagement;
using BankManagement.Classes;
using BankManagement.Classes.Helpers;
using static BankManagement.Enumerators;


Print Print = new Print();
Checks Checks = new Checks();
UserSelect selection = new UserSelect();

do
{
    Console.Clear();
    Print.PrintMsg(EnumPrintId.AddNewUser, EnumColors.White);    
    EnumYesNO selected= selection.GetUserYesNo();

    if (selected == EnumYesNO.Da)
    {
        Console.Clear();
        Print.PrintMsg(EnumPrintId.NewUserHeader, EnumColors.White);
        new NewAccount();
    }
    else if (selected == EnumYesNO.Ne)
    {
        Console.Clear();
        Print.PrintMsg(EnumPrintId.ExistUser, EnumColors.White);
        Print.PrintMsg(EnumPrintId.AccIban, EnumColors.White);
        string IBAN = Console.ReadLine();
        Print.PrintMsg(EnumPrintId.UserOib, EnumColors.White);
        string OIB = Console.ReadLine();

        Users user = Checks.CheckUser(IBAN, OIB);
        Account account = Checks.CheckAccount(IBAN);

        SessionAccount sessionAccount = new SessionAccount(user, account);
        if (sessionAccount.User != null)
        {
           new Menu(sessionAccount);
        }
        else
        {
            Print.PrintMsg(EnumPrintId.AccNotFound, EnumColors.Red);
        }
        sessionAccount = null;
    }
    else 
    {
        Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
        Print.PrintMsg(EnumPrintId.PressEnter, EnumColors.White);
        Console.ReadLine();
        continue;
    }
    
} while (!(new Exit(EnumExit.Main).ReturnBool));

