using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VjezbeC3
{
    public class Enumerators
    {
        public enum EnumAccType 
        {
            //0 reserved for fault
            Tekuci = 1,
            Ziro=2
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
            Ne=2
        }

        public enum EnumExit 
        {
            //0 reserved for fault
            Main=1,
            Menu=2
        }

        public enum EnumUserType
        {
            Privatni,
            Poslovni
        }

    }
}
