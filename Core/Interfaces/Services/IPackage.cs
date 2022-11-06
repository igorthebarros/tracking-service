using Core.Entities;

namespace Core.Interfaces.Services
{
    public interface IPackage
    {
        Task<string> Add();//AddShippingOrderInputModel
        Task<Package> GetByTrackingCode(string trackingCode);
    }
}
