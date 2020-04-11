using DesignPattern.ABFVechicle.ABProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ABFVechicle.Products
{
    class BajajCD100:INormalBike
    {
        public string getNormalBike()
        {
            return "Name CD100 CC: 100cc";
        }
    }
}
