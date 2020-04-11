using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Products
{
    class Moto_G2:ISmartPhones
    {
        public string GetModel()
        {
            return "Model: Moto G2 \n Camera: 13MP \n RAM: 4GB";
        }
    }
}
