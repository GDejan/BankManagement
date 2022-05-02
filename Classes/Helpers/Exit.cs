using BankManagement.Classes.Helpers;
using static BankManagement.Enumerators;

namespace BankManagement.Classes
{
    internal class Exit
    {
        private Print Print = new Print();
        private UserSelect selection = new UserSelect();
        private EnumExit fromWhere { get; set; }
        public bool ReturnBool { get; set; }

        public Exit(EnumExit fromWhere)
        {
            this.fromWhere = fromWhere;
            ExitMenu();
        }

        private void ExitMenu()
        {
            do
            {
                Print.PrintMsg(EnumPrintId.ExitHeader, EnumColors.Red);
                switch (fromWhere)
                {
                    case EnumExit.Menu:
                        Print.PrintMsg(EnumPrintId.CloseUser, EnumColors.White);
                        break;
                    case EnumExit.Main:
                        Print.PrintMsg(EnumPrintId.EndApp, EnumColors.White);
                        break;
                }

                EnumYesNO selected = selection.GetUserYesNo();
                if (selected == EnumYesNO.Da)
                {
                    ReturnBool = true;
                    Console.Clear();
                    break;
                }
                else if (selected == EnumYesNO.Ne)
                {
                    ReturnBool= false;
                    break;
                }
                else
                {
                    Print.PrintMsg(EnumPrintId.WrongInput, EnumColors.Red);
                    continue;
                }

            } while (true);
        }

    }
}
