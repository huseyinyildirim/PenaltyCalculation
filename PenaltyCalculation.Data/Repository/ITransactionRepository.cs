using System.Collections.Generic;
using PenaltyCalculation.Data.Entities;

namespace PenaltyCalculation.Data.Repository
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetAllTransactions();

        Transaction GetTransactionById(int transactionId);

        void CreateTransaction(Transaction transaction);

        void UpdateTransaction(Transaction transaction);

        void DeleteTransaction(Transaction transaction);
    }
}
