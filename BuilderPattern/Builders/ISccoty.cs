using BuilderPattern.Concrete;

namespace BuilderPattern.Builders
{
    public interface IScooty
    {
        Scooty SetName(string name);
        Scooty SetCC(int cc);
        Scooty BreakType(string breakType);
        Scooty fuelCapacity(int fuelCapacity);
        Scooty maxSpeed(int speed);
        string GetScooty();
    }
}
