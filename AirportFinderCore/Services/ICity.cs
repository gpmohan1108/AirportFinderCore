using AirportFinderCore.Models;

namespace AirportFinderCore.Services
{
    public interface ICity
    {
        void Add(CityInfo info);
        List<CityInfo> GetAll();
    }
}
