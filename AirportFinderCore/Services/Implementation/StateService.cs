using AirportFinderCore.Models;
using AirportFinderCore.Repository;

namespace AirportFinderCore.Services.Implementation
{
    public class StateService : IState
    {
        private readonly IRepository<StateImg> _staterepository;
        public StateService(IRepository<StateImg> staterepository)
        {
            _staterepository = staterepository;

        }
        public void Add(StateImg info)
        {
            _staterepository.Add(info);
        }

        public List<StateImg> GetAll()
        {
            return _staterepository.GetAll(); 
        }
    }
}
