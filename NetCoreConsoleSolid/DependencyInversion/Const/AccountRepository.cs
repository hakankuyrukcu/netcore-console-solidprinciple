using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.DependencyInversion.Const
{
    public class AccountRepository : IAccountRepository
    {
        public void SaveAccount(Account account)
        {
            Console.WriteLine("Account has been created");
        }
        public Account GetAccount(int accountId) { return null; }
    }
}
