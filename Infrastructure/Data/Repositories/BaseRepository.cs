using Core.Interfaces.Repositories;

namespace Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
