using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class GiftCardAccount : BankAccount
    {
        private readonly decimal _monthlyDeposit = 0m;

        public GiftCardAccount
            (string name, decimal initialBalance, decimal monthlyDeposit)
            : base(name, initialBalance)
        {
            _monthlyDeposit = monthlyDeposit;
        }

        public override void PerformEndOfMonthTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, "Add monthly deposit");
            }
        }
    }
}
