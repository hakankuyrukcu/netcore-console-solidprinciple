using NetCoreConsoleSolid.LiskovsSubstitution.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.LiskovsSubstitution.Services
{
    public class AddressService
    {
        public virtual Address GetAddressForUser(int userId)
        {
            Require.Check(() => userId > 10);
            // Getting it from a db...
            var address = new Address()
            {
                Street = "1881 street",
                ZipCode = 35560,
                City = "Karsiyaka",
                State = "Izmir",
                Country = "Turkey"
            };
            Require.Check(() => address.ZipCode > 1000);
            return address;
        }
    }
}
