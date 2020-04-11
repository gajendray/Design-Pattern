using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
   public interface IMobilePhone_ABFactory
    {
       ISmartPhones GetSmartPhone();
       INormalPhone GetNormalphone();
    }
}
