using AirportFinderCore.Models;

namespace AirportFinderCore.Services
{
    public interface IState
    {
        void Add(StateImg info);
        List<StateImg> GetAll();
    }
}
