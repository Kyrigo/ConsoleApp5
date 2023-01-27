namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            var newClient = new Client.OrdinaryClient("Гжегош Бжешчишкевич");
            var anotherClient = new Client.VipClient("Витя Шуруп");
            var newAccountForAnother = new BankAccount.SavingAccount(2, 500);
            var newAccount = new BankAccount.SavingAccount(1, 1000);
            var anotherNewAccount = new BankAccount.UnallocatedBullionAccount(1, 1000, 2, 5);
            newClient.AddNewBankAccount(newAccount);
            newClient.AddNewBankAccount(anotherNewAccount);
            anotherClient.AddNewBankAccount(newAccountForAnother);
            

            newAccount.Withdraw(50);
            var compareTo = newClient.CompareTo(anotherClient);
            newAccount.Deposit(100);
            anotherNewAccount.Deposit(50);
            newClient.GetAllBankAccounts();
        }
    }
}