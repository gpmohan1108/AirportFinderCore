namespace AirportFinderCore.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity); 
        List<T> GetAll();             

    }
    
}
