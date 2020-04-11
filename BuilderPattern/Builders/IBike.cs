using BuilderPattern.Concrete;

namespace BuilderPattern.Builders
{
    public interface IBike
    {
        Bike SetName(string name);
        Bike SetCC(int cc);
        Bike BreakType(string breakType);
        Bike fuelCapacity(int fuelCapacity);
        Bike maxSpeed(int speed);
        Bike numberofGears(int noOfGears);
        string GetBike();
    }
}
