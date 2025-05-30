using FinancialControl.Application.DTOs;
using FinancialControl.Domain.Entities;

namespace FinancialControl.Application.Mappers
{
    public class UserMapper
    {
        public static User ToEntity(UserDto dto)
        {
            return new User
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Surname = dto.Surname,
                Email = dto.Email,
                Password = dto.Password,
                Document = dto.Document,
                BirthDate = dto.BirthDate,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                IsEmailConfirmed = false,
                DeletedAt = null
            };
        }

        public static UserDto ToDto(User user)
        {
            return new UserDto
            {
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                Password = user.Password,
                Document = user.Document,
                BirthDate = user.BirthDate
            };
        }
    }
}
