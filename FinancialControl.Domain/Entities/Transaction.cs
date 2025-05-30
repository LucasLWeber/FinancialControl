namespace FinancialControl.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public Origin Origin { get; set; }
        public DateTime CreatedAt { get; set; }
        public Double Amount { get; set; }
    }
}
