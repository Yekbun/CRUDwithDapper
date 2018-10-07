using CRUDwithDapper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDwithDapper.Services
{
    interface IAccountService
    {
        List<Account> GetAccounts(int rowCount, string sort);

        Account GetAccount(string accountNumber);

        bool CreateAccount(Account account);

        bool DeleteAccount(string accountNumber);

        bool UpdateAccount(Account account);
    }
}
