using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        private static int accountNumberSeed = 1;

        private List<Transaction> allTransactions = new List<Transaction>();

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance 
        {
            get
            {
                decimal balance = 0;
                foreach (var transaction in allTransactions)
                {
                    balance += transaction.Amount;
                }

                return balance;
            } 
        }

        private void GenerateRandomAccountSeed()
        {
            Random random = new Random();
            accountNumberSeed =  random.Next(0, 1000000);
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            Transaction deposit = new Transaction(amount, date, "deposit", note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), 
                    "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }

            Transaction withdrawal = new Transaction(-amount, date, "withdrawal", note);
            allTransactions.Add(withdrawal);
        }

        public string GetAccountHistory()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var transaction in allTransactions)
            {

                sb.Append($"A {transaction.Type} was made on: {transaction.Date}\n");

                sb.Append($"For: {
                    (transaction.Amount < 0 
                    ? transaction.Amount * -1 
                    : transaction.Amount)
                    }\n");

                sb.Append($"Note: {transaction.Note}\n");
            }

            return sb.ToString();
        }

        public BankAccount(string name, decimal initialBalance)
        {
            Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");

            GenerateRandomAccountSeed();
            Number = accountNumberSeed.ToString();
        }
    }
}
