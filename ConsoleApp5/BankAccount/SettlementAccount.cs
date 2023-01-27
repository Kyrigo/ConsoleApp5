namespace ConsoleApp5.BankAccount
{
    public class SettlementAccount : BankAccount
    {
        private static double _serviceFee;

        public SettlementAccount(int ownerId, double amount, double serviceFee) : base(ownerId)
        {
            _serviceFee = serviceFee;
        }

        public void DrawDownServiceFee()
        {
            base.Withdraw(Deposit < _serviceFee ? Deposit : _serviceFee);
        }
    }
}