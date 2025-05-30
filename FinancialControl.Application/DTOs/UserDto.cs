namespace FinancialControl.Application.DTOs
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? ConfirmPassword { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
    }
}
