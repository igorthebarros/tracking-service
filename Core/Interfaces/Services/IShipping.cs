using Core.Entities;

namespace Core.Interfaces.Services
{
    public interface IShipping
    {
        Task<List<Shipping>> GetAll();
    }
}
