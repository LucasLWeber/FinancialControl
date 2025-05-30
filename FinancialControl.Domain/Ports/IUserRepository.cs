using FinancialControl.Domain.Entities;

namespace FinancialControl.Domain.Ports
{
    public interface IUserRepository
    {
        Task<User> GetLoggedUser();
        Task CreateUser(User user);
        Task UpdateUser(User user);
        Task DeleteUser(User user);
    }
}
