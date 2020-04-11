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
    class TVS : IABFactoryBikes
    {
        public INormalBike GetNormalBike()
        {
            return new TVSXL();
        }

        public IScooty GetScooty()
        {
            return new TVSJupitor();
        }

        public iSportsBike GetSportsBike()
        {
            return new TVSAppache();
        }
    }
}
