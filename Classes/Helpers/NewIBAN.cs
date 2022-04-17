using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeC3
{
    internal class NewIBAN
    {
        public string newIban { get; private set; }
        public NewIBAN(string accountType)
        {
            Random random = new Random();
            do
            {
                string newIban = random.Next(1000, 9999).ToString();
                foreach (var item in Database.IbanUser.Where(item => (item.Key == newIban)))
                {
                    continue;
                }

                newIban = string.Format("{0}-{1}", accountType, newIban);//oib);
                this.newIban = newIban;
                break;

            } while (true);
        }
    }
}
