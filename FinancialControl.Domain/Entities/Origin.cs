using FinancialControl.Domain.Enums;

namespace FinancialControl.Domain.Entities
{
    public class Origin
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public string Name { get; set; }
        public Operation Operation { get; set; }

    }
}
