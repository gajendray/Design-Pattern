using DesignPattern.AbstractFactoryPattern.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.ConcreteFactory
{
    class Moto:IMobilePhone_ABFactory
    {

        public ISmartPhones GetSmartPhone()
        {
            return new Moto_G2();
        }

        public INormalPhone GetNormalphone()
        {
            return new Moto_flip();
        }
    }
}
