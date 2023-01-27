namespace ConsoleApp5.BankAccount
{
    class UnallocatedBullionAccount : BankAccount
    {
        public int MetalType { get; init; }
        private double _weight;

        public UnallocatedBullionAccount(int ownerId, int metalType) : base(ownerId)
        { 
            MetalType = metalType;
        }

        public new void Refill(double amount, double exchangeRate)
        {
            var bullionAmount = amount / exchangeRate;
            _weight += bullionAmount;
        }

        public new void Withdraw(double amount, double exchangeRate)
        {
            if (_weight * exchangeRate < amount)
            {
                throw new Exception();
            }

            var bullionAmount = amount / exchangeRate;
            _weight -= bullionAmount;
        }
    }
}