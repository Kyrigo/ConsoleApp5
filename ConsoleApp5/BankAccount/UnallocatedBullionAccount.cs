namespace ConsoleApp5.BankAccount
{
    class UnallocatedBullionAccount : BankAccount
    {
        public int MetalType { get; }
        private double ExchangeRate { get; set; }

        public new double AmountMoney => Amount * ExchangeRate;

        public UnallocatedBullionAccount(int ownerId, double amount, int metalType, double exchangeRate) : base(ownerId, amount)
        { 
            MetalType = metalType;
            ExchangeRate = exchangeRate;
            Amount /= ExchangeRate;
        }

        public bool TakeMoney(double amountGramm, out double amount)
        {
            if (amountGramm <= Amount || !IsClosed)
            {
                Amount -= amountGramm;
                amount = amountGramm * ExchangeRate;
                return true;
            }

            amount = 0;

            return false;
        }

        public override bool Refill(double amountMoney)
        {
            if (IsClosed) return false;

            Amount += amountMoney / ExchangeRate;

            return true;
        }

        public override bool TakeMoney(double amountMoney)
        {
            double amountGramm = amountMoney / ExchangeRate;
            if (amountGramm <= Amount || !IsClosed)
            {
                Amount -= amountGramm;
                return true;
            }

            return false;
        }
    }
}