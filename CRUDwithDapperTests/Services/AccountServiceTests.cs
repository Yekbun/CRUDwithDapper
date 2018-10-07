using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUDwithDapper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDwithDapper.Entities;

namespace CRUDwithDapper.Services.Tests
{
    [TestClass()]
    public class AccountServiceTests
    {

        [TestMethod]
        public void testAccountCreate()
        {
            //Arrange
            var service = new AccountService();
            bool request = false;
            var account = new Account { AccountNumber = "test20", AllowedPaymentSchemes = AllowedPaymentSchemes.Bacs, Balance = 0, Status = AccountStatus.Live };
            // Act
            request = service.CreateAccount(account);
            // Assert
            Assert.IsTrue(request);
        }

        [TestMethod]
        public void testAccountUpdate()
        {
            //Arrange
            var service = new AccountService();
            bool request = false;
            var account = new Account { AccountNumber = "test21", AllowedPaymentSchemes = AllowedPaymentSchemes.Bacs, Balance = 0, Status = AccountStatus.Live };
            request = service.CreateAccount(account);
            account = service.GetAccount("test21");
            account.Balance = 10;

            // Act
            request = service.UpdateAccount(account);
            // Assert
            Assert.IsTrue(request);
        }

        [TestMethod]
        public void testAccountDelete()
        {
            //Arrange
            var service = new AccountService();
            bool request = false;
            var account = new Account { AccountNumber = "test22", AllowedPaymentSchemes = AllowedPaymentSchemes.Bacs, Balance = 0, Status = AccountStatus.Live };
            request = service.CreateAccount(account);

            // Act
            request = service.DeleteAccount(account.AccountNumber);
            // Assert
            Assert.IsTrue(request);
        }

        [TestMethod]
        public void testAccountGetSingleAccount()
        {
            //Arrange
            var service = new AccountService();
            var account = new Account();
            // Act
            account = service.GetAccount("test8");
            // Assert
            Assert.AreEqual(account.AccountNumber, "test8");
        }

        [TestMethod]
        public void testAccountGetAll()
        {
            //Arrange
            var service = new AccountService();
            List<Account> accountList = new List<Account>();

            // Act
            accountList = service.GetAccounts(3, "AccountNumber");
            // Assert
            Assert.AreEqual(accountList.ToArray().Length, 3);
        }
    }
}