class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(1, 200.1, 2.0);
            CheckingAccount checkingAccount = new CheckingAccount(2, 400.0, 100.0);

            savingsAccount.Deposit(1000.0);
            savingsAccount.Withdraw(100.0);
            savingsAccount.CalculateInterest();

            checkingAccount.Deposit(1300.0);
            checkingAccount.Withdraw(800.0);

            AccDetails(savingsAccount);
            AccDetails(checkingAccount);
        }

        static void AccDetails(Account account)
        {
            account.Display();
        }
    }
