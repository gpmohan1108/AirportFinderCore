using AirportFinderCore.Models;
using AirportFinderCore.Repository;

namespace AirportFinderCore.Services.Implementation
{
   
    public class FeedBackService : IFeedBack
    {
        private readonly IRepository<FeedBack> _feedbackrepository;
        public FeedBackService(IRepository<FeedBack> feedbackrepository)
        {
            _feedbackrepository = feedbackrepository;

        }
        public void Add(FeedBack info)
        {
            _feedbackrepository.Add(info);  
          
        }

        public List<FeedBack> GetAll()
        {
            return _feedbackrepository.GetAll();    
        }
    }
}
