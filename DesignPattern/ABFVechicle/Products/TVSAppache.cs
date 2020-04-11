using DesignPattern.ABFVechicle.ABProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ABFVechicle.Products
{
    class TVSAppache:iSportsBike
    {
        public string GetSportBike()
        {
            return "Name: Apache RTR 350, cc350cc";
        }
    }
}
