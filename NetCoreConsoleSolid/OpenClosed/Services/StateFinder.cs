using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.OpenClosed.Services
{
    public class StateFinder
    {
        public string GetStateNameForZipCode(int zipCode, AddressVerifier verifier)
        {
            if (!verifier.IsValidZipCode(zipCode))
            {
                throw new InvalidOperationException($"Invalid ZipCode: {zipCode}");
            }

            switch (zipCode)
            {
                case 9:
                    return "Baku";
                case 10:
                    return "Ganja";
                case 11:
                    return "Izmir";
                case 12:
                    return "Istanbul";
                default:
                    throw new InvalidOperationException($"No state is found with {zipCode}");
            }
        }
    }
}
