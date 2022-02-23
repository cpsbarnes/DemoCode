using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            const string AccountNumber1 = "1234567890";     //Checking Account
            const string AccountNumber2 = "1234567891";     //Corp Investment Account1
            const string AccountNumber3 = "1234567892";     //Ind Investment Account
            

            decimal checkInitBal = 1000;        //Initial balance for checking account
            decimal indInvInitBal = 5000;       //Initial balance for individual investment account
            decimal corInvInitBal = 50000;      //Initial balance for Corp investment account1
            decimal corInvIntBal2 = 25000;      //Initial balance for Corp investment account2

            var account = new CheckingAccount("Jim Smith", checkInitBal, "Checking",AccountNumber1 );

            Console.WriteLine($"Chase Demo Banking App");  
            Console.WriteLine($"{ account.accountType} Account {account.Number} for {account.Owner} with {account.Balance} balance.");



            //Checking Account withdrawl and deposits
            account.MakeWithdrawal(200, DateTime.Now, "Groceries");
            account.MakeWithdrawal(600, DateTime.Now, "Car payment");
            account.MakeDeposit(700, DateTime.Now, "IRS Refund");
            Console.WriteLine(account.Log());



           //Coporate investment account transfer
            var xfer = new InvestmentAccount("Corp Account", corInvInitBal, "Invest Account", AccountNumber2);
            Console.WriteLine($"{ xfer.accountType} Account {xfer.Number} for {xfer.Owner} with {xfer.Balance} balance.");
            xfer.transferFunds(corInvInitBal, corInvIntBal2, 10000, DateTime.Now, "Transfer");
            Console.WriteLine(xfer.Log());


            //Withdrawl from Ind Investment account above $500
            var account3 = new InvestmentAccount("Jon Turner", indInvInitBal, "IndInvest",AccountNumber3 );
            Console.WriteLine($"{ account3.accountType} Account {account3.Number} for {account3.Owner} with {account3.Balance} balance.");
            try
            {
                account3.MakeWithdrawal(600, DateTime.Now, "Withdrawl");

            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.ToString());

            }
            Console.WriteLine(account3.Log());
                                 

        }
    }
}