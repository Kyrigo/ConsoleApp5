namespace ConsoleApp5.BankAccount
{
    public sealed class AccretionAccount : BankAccount
    {
        private readonly double _initialDeposit;
        private readonly double _interestRate;

        public AccretionAccount(int ownerId, double deposit, double interestRate) : base(ownerId)
        {
            _initialDeposit = deposit;
            _interestRate = interestRate;
        }

        public override void Withdraw(double amount)
        {
            if (amount < _initialDeposit)
            {
                base.Withdraw(amount);
            }
        }

        public override void Refill(double amount)
        {
            if (amount < _initialDeposit)
            {
                base.Refill(amount);
            }
        }

        public void CapitalizingInterestPerMonth()
        {
            var amount = Deposit * _interestRate / 12;
            base.Refill(amount);
        }
    }
}