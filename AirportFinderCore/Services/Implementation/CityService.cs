using AirportFinderCore.Models;
using AirportFinderCore.Repository;

namespace AirportFinderCore.Services.Implementation
{
    public class CityService : ICity
    {
        private readonly IRepository<CityInfo> _cityRepository;
        public CityService(IRepository<CityInfo> cityRepository)
        {
            _cityRepository = cityRepository;
        }
        public void Add(CityInfo info)
        {
            
            _cityRepository.Add(info);  
        }

        public List<CityInfo> GetAll()
        {
            return _cityRepository.GetAll();    
        }
    }
}
