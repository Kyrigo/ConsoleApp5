using System.Collections;

namespace ConsoleApp5.Client
{
    abstract class Client
    {
        private static int _numId;
        protected readonly int Id;
        protected string FullName;
        protected List<BankAccount.BankAccount> BankAccounts = new();

        public int Identifier => Id;

        protected Client(string fullName)
        {
            _numId += 1;
            Id = _numId;
            FullName = fullName;
        }

        protected bool AddNewBankAccount(BankAccount.BankAccount bankAccount)
        {
            BankAccounts.Add(bankAccount);
            return true;
        }

        public double GetAllAmountOfMoneyInBankAccounts()
        {
            return BankAccounts.Select(x => x.AmountMoney).Sum();
        }

        public IEnumerable GetAllBankAccounts()
        {
            return BankAccounts.Select(x => x.Identify);

        }

        public bool CloseBankAccount(int accountId)
        {
            var bankAccount = BankAccounts.FirstOrDefault(x => x.Identify == accountId);

            if (bankAccount != null)
            {
                if (bankAccount.CloseAccount())
                {
                    return true;
                }
            }

            return false;
        }
    }
}