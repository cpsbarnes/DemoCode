using System;
using System.Collections.Generic;
//**********************************Simple Banking Applicaton*************************
//*********************************Anthony Barnes*********************************


namespace classes
{
    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; set; }
        public string accountType { get; set; }


        public decimal  Source { get; set; }
       
        public decimal Destination { get; set; }


        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        public void transferFunds(decimal  source, decimal destination, decimal amount, DateTime date, string note)
        {


            this.Source = source ;
            this.Destination = Destination;

            decimal Amount = amount;

            if (this.Source  > Amount)
            {

                this.Source -= Amount;
                this.Destination += Amount;
                var transfer = new Transaction(Amount, date, note);
                allTransactions.Add(transfer);

            }
            else
            {
                throw new ArgumentException("Insufficient funds for transfer.");
            }

        }


            public BankAccount(string name, decimal initialBalance, string aType, string aNumber)
        {
            this.Number = aNumber;  //Account Number 
            
            this.Owner = name;      //Account Name 
            this.accountType = aType;  //Account Type 
            if (initialBalance > 0)
                MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

            
        }
        

        private List<Transaction> allTransactions = new List<Transaction>();




        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

            
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }


        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if(accountType == "IndInvest")
            {
                if(amount > 500)
                {
                    throw new ArgumentOutOfRangeException(nameof(amount), "Individual accounts have a withdrawal limit of 500 dollars");

                }
            }
        

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }

            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);

        }
     

        
        
        public string Log()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }
        
    }
}