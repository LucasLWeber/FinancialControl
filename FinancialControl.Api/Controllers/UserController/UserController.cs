using FinancialControl.Application.DTOs;
using FinancialControl.Application.UseCases.UserUseCases;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace FinancialControl.Api.Controllers.UserController
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly CreateUserService _createUserService;

        public UserController(CreateUserService createUserService)
        {
            _createUserService = createUserService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] UserDto user)
        {
            await _createUserService.Execute(user);
            return StatusCode(201, "Usuário criado com sucesso!");
        }
        /* payload para testes
           {
              "name": "Lucas",
              "surname": "Weber",
              "email": "lucasweber321@gmail.com",
              "password": "34514650Lw@",
              "confirmPassword": "34514650Lw@",
              "birthDate": "2002-12-20",
              "document": "04265482058"
            }
         */
    }
}
