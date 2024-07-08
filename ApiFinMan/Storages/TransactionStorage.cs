using ApiFinMan.Models;

namespace ApiFinMan.Storages
{
    public class TransactionStorage : ITransactionStorage
    {
        private readonly DatabaseContext _databaseContext;

        public TransactionStorage(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public void Add(Transaction transaction) 
        {
            _databaseContext.Transactions.Add(transaction);
            _databaseContext.SaveChanges();

        }

        public List<Transaction> GetAll() => _databaseContext.Transactions.ToList();

        public List<Transaction> GetByType(string viewType)
        {
            return _databaseContext.Transactions.Where(x => x.ViewType == viewType).ToList();
        }
    }
}
