using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeC3
{
    internal class SessionAccount
    {
        public Users User { get; set; }
        public Account Account { get; set; }
        public bool IsActiv { get; set; }

        public SessionAccount(Users user, Account account)
        {
            this.User = user;
            this.Account = account;
            this.IsActiv = true;
        }
    }
}
