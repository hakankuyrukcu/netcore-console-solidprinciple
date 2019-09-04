using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.OpenClosed
{
    public class AzerbaijanAddressVerifier : AddressVerifier
    {
        /// <summary>
        /// Validation for Azerbaijan
        /// </summary>
        /// <param name="zipCode">Azerbaijan ZipCode</param>
        /// <returns>Validation result</returns>
        public override bool IsValidZipCode(int zipCode)
        {
            if (zipCode < 5)
            {
                return false;
            }
            return true;
        }
    }
}
