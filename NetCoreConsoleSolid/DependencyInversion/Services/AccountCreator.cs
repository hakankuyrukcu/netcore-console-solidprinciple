using NetCoreConsoleSolid.DependencyInversion.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.DependencyInversion.Services
{
    public class AccountCreator
    {
        private IAccountRepository _accountRepository;
        public AccountCreator(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void SaveAccount(AccountModel accountModel)
        {
            _accountRepository.SaveAccount(new Account(accountModel));
        }
    }
}
