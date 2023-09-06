using AirportFinderCore.Models;

namespace AirportFinderCore.Services
{
    public interface IAirport
    {
        void Add(AirportInfo entity);
        List<AirportInfo> GetAll();
    }
}
