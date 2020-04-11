using DesignPattern.AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.ConcreteFactory
{
    class Nokia:IMobilePhone_ABFactory
    {
        public ISmartPhones GetSmartPhone()
        {
            return new Nokia_Lumia();
        }

        public INormalPhone GetNormalphone()
        {
            return new Nokia_1100();
        }
    }
}
