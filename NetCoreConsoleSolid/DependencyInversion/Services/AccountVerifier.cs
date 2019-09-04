using NetCoreConsoleSolid.DependencyInversion.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.DependencyInversion.Services
{
    public class AccountVerifier
    {
        private IAccountRepository _accountRepository;
        public AccountVerifier(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public bool VerifyAccount(int accountId)
        {
            return _accountRepository.GetAccount(accountId) == null;
        }
    }
}
