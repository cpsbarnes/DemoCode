//*********************************************Checking Account Class*********************************
//***************************************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string name, decimal initialBalance, string accountType, string acctNum) : base(name, initialBalance, accountType, acctNum )
        {

        }


    }
}
