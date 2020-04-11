using BuilderPattern.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Concrete
{
    public class Bike : IBike
    {
        private string _breakType;
        private int _fuelCapacity;
        private int _maxSpeed;
        private int _noOfGears;
        private int _cc;
        private string _name;

        public Bike BreakType(string breakType)
        {
            _breakType = breakType;
            return this;
        }

        public Bike fuelCapacity(int fuelCapacity)
        {
            _fuelCapacity = fuelCapacity;
            return this;
        }

        public Bike maxSpeed(int speed)
        {
            _maxSpeed = speed;
            return this;
        }

        public Bike numberofGears(int noOfGears)
        {
            _noOfGears = noOfGears;
            return this;
        }

        public Bike SetCC(int cc)
        {
            _cc = cc;
            return this;
        }

        public Bike SetName(string name)
        {
            _name = name;
            return this;
        }

        public string GetBike()
        {
           return $"Name: {_name} \n" +
                $"CC: {_cc} \n" +
                $"Breaktype: {_breakType} \n" +
                $"Fuel Capacity: {_fuelCapacity} \n" +
                $"Max speed: {_maxSpeed} \n" +
                $"Number of gears : {_noOfGears} \n";
        }
    }
}
