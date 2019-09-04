using System;
using System.Collections.Generic;
using System.Text;

namespace NetCoreConsoleSolid.InterfaceSegregation.Const
{
    public class Human : IHuman, ICanEat, IFeedable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Feed(string food)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Sleep()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
}
