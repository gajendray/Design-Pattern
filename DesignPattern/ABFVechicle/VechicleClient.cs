
using DesignPattern.ABFVechicle.ABProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AB
{
    class VechicleClient
    {
        private readonly INormalBike _iNormalBike;
        private readonly IScooty _iScooty;
        private readonly iSportsBike _iSportsBike;
        public VechicleClient(IABFactoryBikes iABVechicles)
        {
            _iNormalBike = iABVechicles.GetNormalBike();
            _iScooty = iABVechicles.GetScooty();
            _iSportsBike = iABVechicles.GetSportsBike();
        }

        public string GetNormalBike()
        {
            return _iNormalBike.getNormalBike();
        }
        public string GetSportsBike()
        {
            return
                _iSportsBike.GetSportBike();
        }

        public string GetScooty()
        {
            return _iScooty.GetScooty();
        }
        
    }
}
