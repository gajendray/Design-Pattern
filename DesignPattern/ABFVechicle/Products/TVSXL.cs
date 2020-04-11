using DesignPattern.ABFVechicle.ABProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ABFVechicle.Products
{
    class TVSXL:INormalBike
    {
        public string getNormalBike()
        {
            return "Name: TVS XL, CC:98cc";
        }
    }
}
