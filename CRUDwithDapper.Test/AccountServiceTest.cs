using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDwithDapper.Test
{
  

        [TestClass]
        public class AccountServiceTest
        {
            [TestMethod]
            public void testAccountCreate()
            {
                //Arrange
                var service = new AccountService();
                bool request = false;
                var account = new Account { AccountNumber = "test5", AllowedPaymentSchemes = AllowedPaymentSchemes.Bacs, Balance = 0, Status = AccountStatus.Live };
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
                var account = new Account { AccountNumber = "test8", AllowedPaymentSchemes = AllowedPaymentSchemes.Bacs, Balance = 0, Status = AccountStatus.Live };
                request = service.CreateAccount(account);
                account = service.GetAccount("test8");
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
                var account = new Account { AccountNumber = "test7", AllowedPaymentSchemes = AllowedPaymentSchemes.Bacs, Balance = 0, Status = AccountStatus.Live };
                request = service.CreateAccount(account);

                // Act
                request = service.DeleteAccount(account.AccountNumber);
                // Assert
                Assert.IsTrue(request);
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
