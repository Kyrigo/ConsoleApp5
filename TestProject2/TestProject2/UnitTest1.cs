using ConsoleApp5.BankAccount;
using NUnit.Framework;

namespace TestProject2;

public class Tests
{
    [Test]
    public void Test1()
    {
        double expectedBalance = 99;
        double fee = 1;
        double beginningBalance = 100;
        
        BankAccount account = new SettlementAccount(1, beginningBalance, fee);

        SettlementAccount.DrawDownServiceFee();
        Assert.AreEqual(expectedBalance, account.AmountMoney, "Fee draw down incorrect");
    }
}