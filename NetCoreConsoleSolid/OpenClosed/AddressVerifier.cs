using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.OpenClosed
{
    public class AddressVerifier
    {
        /// <summary>
        /// Validation for Turkey
        /// Virtual for be able to override
        /// </summary>
        /// <param name="zipCode">Turkey ZipCode</param>
        /// <returns>Validation result</returns>
        public virtual bool IsValidZipCode(int zipCode)
        {
            if (zipCode < 10)
            {
                return false;
            }
            return true;
        }
    }
}
