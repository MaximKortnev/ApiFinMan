using ApiFinMan.Models;

namespace ApiFinMan.Storages
{
    public interface ITransactionStorage
    {
        public void Add(Transaction transaction);
        public List<Transaction> GetAll();
        public List<Transaction> GetByType(string type);
    }
}
