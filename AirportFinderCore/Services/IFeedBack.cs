using AirportFinderCore.Models;

namespace AirportFinderCore.Services
{
    public interface IFeedBack
    {
        void Add(FeedBack info);
        List<FeedBack> GetAll();
    }
}
