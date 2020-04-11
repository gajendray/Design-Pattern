using BuilderPattern;
using BuilderPattern.Concrete;
using BuilderPattern.Models;
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
        private Engineer _engineer;

        public BajajCD100()
        {
            _engineer = new Engineer();
        }

        public string getNormalBike()
        {
            var bike = new Bike();
            BikeModel normalBike = new BikeModel
            {
                 BreakType = "Drum",
                 Cc = 100,
                 FuelCapacity = 12,
                 MaxSpeed = 140,
                 Name = "Bajaj CD 100",
                 NoOfGears = 4
            };
            return _engineer.BuildNormalBike(bike, normalBike);
        }
    }
}
