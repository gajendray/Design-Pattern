using BuilderPattern.Builders;

namespace BuilderPattern.Concrete
{
    public class Scooty : IScooty
    {
        private string _breakType;
        private int _fuelCapacity;
        private int _maxSpeed;
        private int _cc;
        private string _name;

        public Scooty BreakType(string breakType)
        {
            _breakType = breakType;
            return this;
        }

        public Scooty fuelCapacity(int fuelCapacity)
        {
            _fuelCapacity = fuelCapacity;
            return this;
        }

        public Scooty maxSpeed(int speed)
        {
            _maxSpeed = speed;
            return this;
        }

        public Scooty SetCC(int cc)
        {
            _cc = cc;
            return this;
        }

        public Scooty SetName(string name)
        {
            _name = name;
            return this;
        }

        public string GetScooty()
        {
            return $"Name: {_name} \n" +
                $"CC: {_cc} \n" +
                $"Breaktype: {_breakType} \n" +
                $"Fuel Capacity: {_fuelCapacity} \n" +
                $"Max speed: {_maxSpeed} \n";
        }
    }
}
