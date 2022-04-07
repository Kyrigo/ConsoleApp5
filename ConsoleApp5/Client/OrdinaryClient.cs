namespace ConsoleApp5.Client
{
    class OrdinaryClient : ConsoleApp5.Client.Client
    {
        public new bool AddNewBankAccount(BankAccount.BankAccount bankAccount)
        {
            if (BankAccounts.Count >= 3) return false;

            base.AddNewBankAccount(bankAccount);

            return true;
        }

        public OrdinaryClient(string fullName) : base(fullName) { }
    }
}
