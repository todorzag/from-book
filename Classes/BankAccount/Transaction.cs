using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class Transaction
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }
        public string Type { get; }

        public Transaction(decimal amount, DateTime date,string type, string note)
        {
            Amount = amount;
            Date = date;
            Type = type;
            Note = note;
        }
    }
}
