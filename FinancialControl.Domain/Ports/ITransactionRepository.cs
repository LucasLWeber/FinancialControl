using FinancialControl.Domain.Entities;

namespace FinancialControl.Domain.Ports
{
    public interface ITransactionRepository
    {
        Task<Transaction> GetTransactionById(Guid transactionId);
        Task<List<Transaction>> GetAllTransactions();
        Task CreateTransaction(Transaction transaction);
        Task UpdateTransaction(Guid transactionId, Transaction transaction);
        Task DeleteTransaction(Guid transactionId); 
    }
}
