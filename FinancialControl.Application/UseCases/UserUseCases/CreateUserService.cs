
using FinancialControl.Domain.Ports;
using FinancialControl.Domain.Entities;
using FinancialControl.Application.DTOs;
using FinancialControl.Application.Mappers;

namespace FinancialControl.Application.UseCases.UserUseCases
{
    public class CreateUserService
    {
        private readonly IUserRepository _userRepository;

        public CreateUserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task Execute(UserDto userDto)
        {
            // Criar exception handler e tratar regra de negócio aqui
            var user = UserMapper.ToEntity(userDto);
            await _userRepository.CreateUser(user);
        }
    }
}
