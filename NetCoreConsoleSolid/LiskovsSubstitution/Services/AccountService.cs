using NetCoreConsoleSolid.LiskovsSubstitution.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.LiskovsSubstitution.Services
{
    public class AccountService
    {
        public void ChangeAddress(Address address)
        {
            Require.Check(() => address.ZipCode > 1000);
            // Save the address in db or send to service.
            Console.WriteLine("Account address has been changed succesfully");
        }
    }
}
