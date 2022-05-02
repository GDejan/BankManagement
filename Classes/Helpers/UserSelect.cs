using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement.Classes.Helpers
{
    class UserSelect
    {  
        private string selection { get; set; }
        public EnumYesNO GetUserYesNo()
        {
            selection = Console.ReadLine().ToLower();
            if (selection == EnumYesNO.Da.ToString().ToLower()) return EnumYesNO.Da;
            else if (selection == EnumYesNO.Ne.ToString().ToLower()) return EnumYesNO.Ne;
            else return 0;
        }
        public EnumAccType GetUserAccType()
        {
            selection = Console.ReadLine().ToLower();
            if (selection == EnumAccType.Tekuci.ToString().ToLower()) return EnumAccType.Tekuci;
            else if (selection == EnumAccType.Ziro.ToString().ToLower()) return EnumAccType.Ziro;
            else return 0;
        }

    }
}
