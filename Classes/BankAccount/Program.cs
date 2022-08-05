namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter bank account name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter initial balance:");
            decimal initialBalance = ValidateAmount();

            BankAccount account = new BankAccount(name, initialBalance);

            MakeTransaction(account);

            Console.WriteLine(account.GetAccountHistory());
        }


        private static decimal ValidateAmount()
        {
            decimal amount = int.MinValue;
            try
            {
                amount = decimal.Parse(Console.ReadLine());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Please enter a numeric value!");
                ValidateAmount();
            }

            return amount;
        }

        private static void MakeTransaction(BankAccount account)
        {
            Console.WriteLine("What kind of transaction would you like to make?");
            string transactionType = Console.ReadLine();
            ValidateTransactionType(transactionType);

            Console.WriteLine("For what amount?");
            decimal amount = ValidateAmount();
            string note = AddNote();

            switch (transactionType)
            {
                case "deposit":
                    account.MakeDeposit(amount, DateTime.Now, note);
                    break;

                case "withdrawal":
                    account.MakeWithdrawal(amount, DateTime.Now, note);
                    break;
            }

            Console.WriteLine("Transaction Completed!");
            Console.WriteLine("Make another transaction?");
            string answer = Console.ReadLine();

            switch (answer)
            {
                case "yes":
                    MakeTransaction(account);
                    break;
            }
        }

        private static string AddNote()
        {
            Console.WriteLine("Please add a note with your transaction.");
            string note = Console.ReadLine();

            return note;
        }

        private static string ValidateTransactionType(string transactionType)
        {
            if (transactionType != "deposit" && transactionType != "withdrawal")
            {
                Console.WriteLine("Please enter valid transaction type!");

                transactionType = Console.ReadLine();
                ValidateTransactionType(transactionType);
            }

            return transactionType;
        }
    }
}