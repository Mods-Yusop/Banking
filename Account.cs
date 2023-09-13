
    abstract class Account
    {
         public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public Account(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"you Deposited ${amount} into Account {AccountNumber}. your new balance is: ${Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount!");
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"You have Withdrawn ${amount} from the account {AccountNumber}. Your new balance is: ${Balance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds!");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount!");
            }
        }    

        public abstract void Display();
    }
