using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Models
{
    public class BikeModel
    {
        private string _breakType;
        private int _fuelCapacity;
        private int _maxSpeed;
        private int _noOfGears;
        private int _cc;
        private string _name;

        public string BreakType { get => _breakType; set => _breakType = value; }
        public int FuelCapacity { get => _fuelCapacity; set => _fuelCapacity = value; }
        public int MaxSpeed { get => _maxSpeed; set => _maxSpeed = value; }
        public int NoOfGears { get => _noOfGears; set => _noOfGears = value; }
        public int Cc { get => _cc; set => _cc = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
