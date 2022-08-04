using System.Collections;

namespace ConsoleApp5.Client
{
    abstract class Client : IComparable<Client>
    {
        private static int _numId;
        protected readonly int Id;
        protected string FullName;
        protected List<BankAccount.BankAccount> BankAccounts = new();

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

        public int CompareTo(Client client)
        {
            if (this.GetAllAmountOfMoneyInBankAccounts() < client.GetAllAmountOfMoneyInBankAccounts()) return -1;
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            if (this.GetAllAmountOfMoneyInBankAccounts() == client.GetAllAmountOfMoneyInBankAccounts()) return 0;
            return 1;
        }
    }
}