using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Products
{
    class Samsung_Galaxy:ISmartPhones
    {
        public string GetModel()
        {
            return "Model: Samsung_GalaxyS10_Edge \n Camera: 35px \n RAM: 6GB";
        }
    }
}
