using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.DependencyInversion.Const
{
    public class Account
    {
        public Account() { }
        public Account(AccountModel accountModel)
        {
            this.FirstName = accountModel.FirstName;
            this.LastName = accountModel.LastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
