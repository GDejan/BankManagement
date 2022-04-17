using VjezbeC3.Classes.Helpers;
using static VjezbeC3.Enumerators;

namespace VjezbeC3.Classes
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
                Print.PrintMsg(110, EnumColors.Red);
                switch (fromWhere)
                {
                    case EnumExit.Menu:
                        Print.PrintMsg(48, EnumColors.White);
                        break;
                    case EnumExit.Main:
                        Print.PrintMsg(49, EnumColors.White);
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
                    Print.PrintMsg(100, EnumColors.Red);
                    continue;
                }

            } while (true);
        }

    }
}
