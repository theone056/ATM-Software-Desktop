using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMLib.FACADE.Interface
{
    interface IATMFACADE
    {
        bool validateCard(string cardnumber)
    }
}
