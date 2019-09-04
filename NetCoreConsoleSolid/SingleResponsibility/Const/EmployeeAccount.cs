using NetCoreConsoleSolid.SingleResponsibility.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.SingleResponsibility.Const
{
    public class EmployeeAccount
    {
        public Guid AccountId { get; set; }
        public Profile Profile { get; set; }
        public Address Address { get; set; }
        public LoginInfo LoginInfo { get; set; }
    }
}
