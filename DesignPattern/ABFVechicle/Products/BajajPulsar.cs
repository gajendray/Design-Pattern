using DesignPattern.ABFVechicle.ABProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ABFVechicle.Products
{
    class BajajPulsar:iSportsBike
    {
        public string GetSportBike()
        {
            return "Name: Pulsar 220, CC: 220cc";
        }
    }
}
