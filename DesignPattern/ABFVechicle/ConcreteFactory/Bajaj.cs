using DesignPattern.AB;
using DesignPattern.ABFVechicle.ABProduct;
using DesignPattern.ABFVechicle.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesignPattern.ABFVechicle.ConcreteFactory
{
  public  class Bajaj : IABFactoryBikes
    {
        public INormalBike GetNormalBike()
        {
            return new BajajCD100();
        }

        public IScooty GetScooty()
        {
            return new BajajChetak();
        }

        public iSportsBike GetSportsBike()
        {
            return new BajajPulsar();
        }
    }
}
