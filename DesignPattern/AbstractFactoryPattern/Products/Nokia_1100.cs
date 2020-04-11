using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Products
{
    class Nokia_1100:INormalPhone
    {
        public string GetModelDetails()
        {
            return "Model: Nokia_1100 \n Camera:No \n RAM:512MB";
        }
    }
}
