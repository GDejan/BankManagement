using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeC3
{
    abstract internal class Users
    {
        public bool IsPrivate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string OiB { get; set; }
        public string IBAN { get; set; }

        public Users( string name, string surname, string Oib, string iban, bool isPrivate)
        {
            this.Name = name;
            this.Surname = surname;
            this.OiB = Oib;
            this.IBAN = iban;
            this.IsPrivate = isPrivate;
        }
        public string FullName() 
        {
            return string.Format(Name + " " + Surname);
        }
    }
}
