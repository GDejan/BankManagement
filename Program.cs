using VjezbeC3;
using VjezbeC3.Classes;
using VjezbeC3.Classes.Helpers;
using static VjezbeC3.Enumerators;

Print Print = new Print();
Checks Checks = new Checks();
UserSelect selection = new UserSelect();

do
{
    Console.Clear();
    Print.PrintMsg(30, EnumColors.White);    
    EnumYesNO selected= selection.GetUserYesNo();

    if (selected == EnumYesNO.Da)
    {
        Console.Clear();
        Print.PrintMsg(31, EnumColors.White);
        new NewAccount();
    }
    else if (selected == EnumYesNO.Ne)
    {
        Console.Clear();
        Print.PrintMsg(32, EnumColors.White);
        Print.PrintMsg(1, EnumColors.White);
        string IBAN = Console.ReadLine();
        Print.PrintMsg(2, EnumColors.White);
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
            Print.PrintMsg(101, EnumColors.Red);
        }
        sessionAccount = null;
    }
    else 
    {
        Print.PrintMsg(100, EnumColors.Red);
        Print.PrintMsg(15, EnumColors.White);
        Console.ReadLine();
        continue;
    }
    
} while (!(new Exit(EnumExit.Main).ReturnBool));

