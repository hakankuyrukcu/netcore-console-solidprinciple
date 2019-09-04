using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.InterfaceSegregation.Const
{
    public interface IHuman
    {
        void Talk();
        void Walk();
        void Sleep();
        void Run();
    }
}
