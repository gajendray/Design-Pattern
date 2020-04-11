using DesignPattern.ABFVechicle.ABProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AB
{
    public interface IABFactoryBikes
    {
        INormalBike GetNormalBike();
        IScooty GetScooty();
        iSportsBike GetSportsBike();
    }
}
