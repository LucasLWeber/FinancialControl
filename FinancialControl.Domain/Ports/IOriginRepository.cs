using FinancialControl.Domain.Entities;

namespace FinancialControl.Domain.Ports
{
    public interface IOriginRepository
    {
        Task<Origin> GetOriginById(Guid originId);
        Task<List<Origin>> GetAllOrigins();
        Task CreateOrigin(Origin origin);
        Task UpdateOrigin(Guid originId, Origin origin);
        Task DeleteOrigin(Guid originId);
    }
}
