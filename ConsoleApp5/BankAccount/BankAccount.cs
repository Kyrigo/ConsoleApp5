namespace ConsoleApp5.BankAccount
{
    public abstract class BankAccount
    {
        private static int _numId;
        protected int Id;
        protected int OwnerId;
        protected double Amount;        
        protected bool IsClosed = false;
        public int Identify => Id;

        public double AmountMoney => Amount;

        protected BankAccount(int ownerId, double amount)
        {
            _numId++;
            Id = _numId;
            OwnerId = ownerId;
            Amount = amount;
        }

        public bool CloseAccount()
        {
            if (Amount != 0) return false;

            IsClosed = true;

            return true;
        } 
        public abstract bool Refill(double amountMoney); 
        
        public abstract bool TakeMoney(double amountMoney);
    }
}