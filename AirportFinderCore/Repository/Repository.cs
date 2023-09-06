namespace AirportFinderCore.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DataBaseContext _dbcontext;
        public Repository(DataBaseContext dbcontext)
        {
            _dbcontext = dbcontext;

        }
        public void Add(T entity)
        {
            _dbcontext.Set<T>().Add(entity); 
            _dbcontext.SaveChanges();
             
        }

        public List<T> GetAll()
        {
            return _dbcontext.Set<T>().ToList();
        }
    }

}
