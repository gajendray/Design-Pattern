using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Products
{
    class Nokia_Lumia:ISmartPhones
    {

     public   string GetModel()
        {
            return "Model: Nokia_Lumia_Smart_Andriod10 \n Camera:12MP \n RAM:2GB";
        }
    }
}
