using NetCoreConsoleSolid.LiskovsSubstitution.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.LiskovsSubstitution.Services
{
    public class NewAddressService : AddressService
    {
        public override Address GetAddressForUser(int userId)
        {
            Require.Check(() => userId > 10);
            Require.Check(() => userId < 30);
            // Getting it from a service...
            var address = new Address()
            {
                Street = "Test Street",
                ZipCode = 900,
                City = "Murray",
                State = "New England",
                Country = "USA"
            };
            return address;
        }
    }
}
