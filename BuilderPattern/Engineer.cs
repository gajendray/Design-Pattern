using BuilderPattern.Builders;
using BuilderPattern.Models;

namespace BuilderPattern
{
    public class Engineer
    {
        public string BuildNormalBike(IBike bike, BikeModel bikeModel)
        {
            return bike.BreakType(bikeModel.BreakType)
                .fuelCapacity(bikeModel.FuelCapacity)
                .SetCC(bikeModel.Cc)
                .numberofGears(bikeModel.NoOfGears)
                .maxSpeed(bikeModel.MaxSpeed)
                .SetName(bikeModel.Name)
                .GetBike();
        }

        public string BuildScooty(IScooty scooty)
        {
            return scooty.BreakType("drum")
                .fuelCapacity(8)
                .SetCC(150)
                .maxSpeed(140)
                .SetName("Activa 4G")
                .GetScooty();
        }
    }
}
