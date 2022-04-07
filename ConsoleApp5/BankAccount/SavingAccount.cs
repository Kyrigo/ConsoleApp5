namespace ConsoleApp5.BankAccount
{
    class SavingAccount : BankAccount
    {
        public SavingAccount(int ownerId, double amount) : base(ownerId, amount) { }

        public override bool TakeMoney(double amountMoney)
        {
            if (amountMoney > Amount || IsClosed) return false;

            Amount -= amountMoney;

            return true;
        }

        public override bool Refill(double amountMoney)
        {
            if (IsClosed) return false;

            Amount += amountMoney;

            return true;
        }
    }
}