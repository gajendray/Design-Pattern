using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactoryPattern
{
    class MobileClient
    {
        private readonly ISmartPhones _smartphone;
        private readonly INormalPhone _normarphone;
        public MobileClient(IMobilePhone_ABFactory factory)
        {
            _smartphone = factory.GetSmartPhone();
            _normarphone = factory.GetNormalphone();
        }

        public string getsmartphonedetails()
        {
            return _smartphone.GetModel();
        }

        public string getnormalphonedetails()
        {
            return _normarphone.GetModelDetails();
        }
    }
}
