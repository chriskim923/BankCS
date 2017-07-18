using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankAccountNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS.Tests
{
    [TestClass()]
    public class BankAccountTests
    {
        [TestMethod()]
        public void DebitTest()
        {
            BankAccount target = new BankAccount("Mr. Bryan Walton", 11.99);
            double amount = 11.22;
            target.Debit(amount);
            Assert.AreEqual((System.Convert.ToDouble(0.77)), target.Balance, 0.05);
        }

        [TestMethod()]
        public void CreditTest()
        {
            BankAccount target = new BankAccount("Mr. Bryan Walton", 11.99);
            double amount = 11.01;
            target.Credit(amount);
            Assert.AreEqual((System.Convert.ToDouble(23.00)), target.Balance, 0.05);
        }
    }
}