using NetCoreConsoleSolid.SingleResponsibility.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.SingleResponsibility.Services
{
    public class AddressService
    {
        public void ChangeAddress(Guid accountId, Address newAddress)
        {
            Console.WriteLine("Changed address");
        }
    }
}
