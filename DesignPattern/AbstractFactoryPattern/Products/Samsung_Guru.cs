using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern.Products
{
  public  class Samsung_Guru:INormalPhone
    {
      public string GetModelDetails()
        {
            return "Model: Nokia_1100 \n Camera:2MP \n RAM:512MB";
        }
    }
}
