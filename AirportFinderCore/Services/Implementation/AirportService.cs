using AirportFinderCore.Models;
using AirportFinderCore.Repository;

namespace AirportFinderCore.Services.Implementation
{
    public class AirportService : IAirport
    {
        private readonly IRepository<AirportInfo> _airportInfoRepository;
        public AirportService(IRepository<AirportInfo> airportInfoRepository)
        {

            _airportInfoRepository = airportInfoRepository;
        }

        public void Add(AirportInfo entity)
        {
            _airportInfoRepository.Add(entity);
        }

        public List<AirportInfo> GetAll()
        {
            return _airportInfoRepository.GetAll();
        }
    }
}
