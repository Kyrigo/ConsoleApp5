namespace ConsoleApp5.Bank
{
    public class Bank
    {
       public bool TransferMoneyFromAccountToAccount(BankAccount.BankAccount senderAccount, BankAccount.BankAccount recipientAccount, double ammountMoney)
        {
            if (ammountMoney > senderAccount.AmountMoney) return false;

            senderAccount.Withdraw(ammountMoney);
            recipientAccount.Refill(ammountMoney);

            return true;
        }
    }
}
