using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankManagement.Enumerators;

namespace BankManagement
{
    static class Database
    {

        public static Dictionary<string, Account> IbanAccount = new Dictionary<string, Account>()
        {
            {"T-1234", new StandardAcc("T-1234",1000.0m,EnumAccType.Tekuci)},
            {"T-2345", new StandardAcc("T-2345",1000.0m,EnumAccType.Tekuci)},
            {"Z-2345", new GiroAcc("Z-1234",EnumAccType.Ziro)},
            {"Z-3456", new GiroAcc("Z-3456",EnumAccType.Ziro)},
            {"T-3456", new StandardAcc("T-2345",10000.0m,EnumAccType.Tekuci)},
        };  
        public static Dictionary<string, Users> IbanUser = new Dictionary<string, Users>()
        {
            {"T-1234",new PrivateUser("Pero", "Peric","1234","T-1234",EnumUserType.Privatni)},
            {"T-2345",new PrivateUser("Nika", "Nikic","2345","T-2345",EnumUserType.Privatni)},
            {"Z-2345",new PrivateUser("Nika", "Nikic","2345","Z-2345",EnumUserType.Privatni)},
            {"Z-3456",new BusinessUser("Jura", "Juric","3456","Z-3456","Juric d.o.o.", EnumUserType.Poslovni)},
            {"T-3456",new PrivateUser("Jura", "Juric","3456","T-3456",EnumUserType.Privatni)}
        };

        
    }
}
