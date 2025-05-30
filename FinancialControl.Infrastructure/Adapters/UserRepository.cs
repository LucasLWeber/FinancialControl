using FinancialControl.Domain.Entities;
using FinancialControl.Domain.Ports;
using FinancialControl.Infrastructure.Data;

namespace FinancialControl.Infrastructure.Adapters
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task CreateUser(User user)
        {
            await _appDbContext.Users.AddAsync(user);   
            await _appDbContext.SaveChangesAsync();
        }

        public async Task DeleteUser(User user)
        {
            var userDb = await _appDbContext.Users.FindAsync(user.Id);

            if (userDb == null) throw new Exception("Usuário não encontrado");
            
            userDb.DeletedAt = DateTime.UtcNow;
            await _appDbContext.SaveChangesAsync();
        }

        public Task<User> GetLoggedUser()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateUser(User user)
        {
            _appDbContext.Users.Update(user);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
