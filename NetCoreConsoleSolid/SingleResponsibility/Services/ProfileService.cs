using NetCoreConsoleSolid.SingleResponsibility.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.SingleResponsibility.Services
{
    public class ProfileService
    {
        public Profile GetProfile(Guid accountId)
        {
            return new Profile();
        }
    }
}
