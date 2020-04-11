using DesignPattern.AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.ConcreteFactory
{
    class Samsung:IMobilePhone_ABFactory
    {

        public ISmartPhones GetSmartPhone()
        {
            return new Samsung_Galaxy();
        }

        public INormalPhone GetNormalphone()
        {
            return new Samsung_Guru();
        }
    }
}
