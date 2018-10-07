using CRUDwithDapper.Data;
using CRUDwithDapper.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDwithDapper.Services
{
    public class AccountService:IAccountService
    {
         public Account GetAccount(string accountNumber)
        {
            IAccountDataStore accountDataStore = new AccountDataStore();
            return accountDataStore.GetAccount(accountNumber);
        }

        public List<Account> GetAccounts(int rowCount, string sort)
        {
            IAccountDataStore accountDataStore = new AccountDataStore();
            return accountDataStore.GetAccounts(rowCount, sort);
        }

        public bool CreateAccount(Account account)
        {
             IAccountDataStore accountDataStore = new AccountDataStore();
            return accountDataStore.CreateAccount(account);
        }

        public bool DeleteAccount(string accountNumber)
        {
              IAccountDataStore accountDataStore = new AccountDataStore();
            return accountDataStore.DeleteAccount(accountNumber);
        }

        public bool UpdateAccount(Account account)
        {
             IAccountDataStore accountDataStore = new AccountDataStore();
            return accountDataStore.UpdateAccount(account);
        }
    }
}
