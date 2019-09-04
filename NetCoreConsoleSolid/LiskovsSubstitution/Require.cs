using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.LiskovsSubstitution
{
    public static class Require
    {
        public static void Check(Func<bool> control)
        {
            if (!control())
            {
                throw new ArgumentException("Invalid argument has been passed.");
            }
        }
    }
}
