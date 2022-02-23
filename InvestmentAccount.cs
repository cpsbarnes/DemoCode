//***************************************Investment Account Class*****************************************
//********************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    

    public class InvestmentAccount : BankAccount
    {

        public InvestmentAccount(string name, decimal initialBalance, string accountType, string actNumber) : base(name, initialBalance, accountType, actNumber )
        {

        }
     
    }
}
