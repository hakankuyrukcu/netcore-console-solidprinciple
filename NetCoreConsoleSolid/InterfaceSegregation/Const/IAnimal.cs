using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.InterfaceSegregation.Const
{
    public interface IAnimal
    {
        void Bark();
        void Walk();
        void Sleep();
        void Run();
        void Bite();
    }
}
