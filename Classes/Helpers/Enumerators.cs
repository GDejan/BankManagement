using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Enumerators
    {
        public enum EnumAccType 
        {
            //0 reserved for fault
            Tekuci = 1,
            Ziro = 2
        }
        public enum EnumColors 
        {
            White,
            Green,
            Red
        }
        public enum EnumYesNO
        {
            //0 reserved for fault
            Da = 1,
            Ne = 2
        }

        public enum EnumExit 
        {
            //0 reserved for fault
            Main = 1,
            Menu = 2
        }

        public enum EnumUserType
        {
            Privatni,
            Poslovni
        }

        public enum EnumPrintId
        {
            AccIban,
            UserOib,
            UserName,
            UserSurname,
            NewUserYesNo,
            IsBussines,
            CompanyName,
            AccType,
            AccOwerdraft,
            BalanceAcc,
            PlusAmount,
            MinusAmount,
            HistoryHeader,
            EndHeader,
            PressEnter,
            BalanceHeader,
            PrintMenu,
            AddNewUser,
            NewUserHeader,
            ExistUser,
            CloseUser,
            EndApp,
            UserAddedHeader,
            NewAccountHeader,
            WrongInput,
            AccNotFound,
            IssufientBalance,
            ExitHeader
        }

    }
}
