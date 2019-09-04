using NetCoreConsoleSolid.SingleResponsibility.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.SingleResponsibility
{
    public class AddressVerifier
    {
        public bool IsAddressValid(Address address, AddressTypeEnum addressType)
        {
            switch (addressType)
            {
                case AddressTypeEnum.Customer:
                    Console.WriteLine("Customer address is valid");
                    break;
                case AddressTypeEnum.Employee:
                    Console.WriteLine("Employee address is valid");
                    break;
                default:
                    throw new InvalidOperationException();
            }
            return true;
        }
    }
}
