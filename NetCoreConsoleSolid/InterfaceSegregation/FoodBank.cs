using NetCoreConsoleSolid.InterfaceSegregation.Const;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.InterfaceSegregation
{
    public class FoodBank
    {
        public void AddToList(ICanEat caneat)
        {
            throw new NotImplementedException();
        }
    }
}
