using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Products
{
    class Moto_flip:INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Motorola-flip \n camera:No \n RAM:512MB";
        }
    }
}
