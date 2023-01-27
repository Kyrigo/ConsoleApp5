namespace ConsoleApp5.BankAccount
{
    public abstract class BankAccount
    {
        protected Guid Id { get; init; }
        private readonly int _ownerId;
        protected double Deposit { get; private set; }
        private bool _isClosed;
        public Guid Identify => Id;

        public double AmountMoney => Deposit;

        protected BankAccount(int ownerId)
        {
            Id = Guid.NewGuid();
            _ownerId = ownerId;
            _isClosed = false;
        }
        

        public virtual bool TryClose()
        {
            if (Deposit > 0) return false;
            _isClosed = true;
            return true;
        }

        public virtual void Refill(double amount)
        {
            if (!_isClosed)
            {
                Deposit += amount;
            }
        }

        public virtual void Withdraw(double amount)
        {
            if (!_isClosed && amount <= Deposit)
            {
                Deposit -= amount;
            }
        }
    }
}