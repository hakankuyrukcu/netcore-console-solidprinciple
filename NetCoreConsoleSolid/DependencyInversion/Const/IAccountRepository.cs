using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.DependencyInversion.Const
{
    public interface IAccountRepository
    {
        void SaveAccount(Account account);
        Account GetAccount(int accountId);
    }
}
