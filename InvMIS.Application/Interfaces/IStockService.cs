using InvMIS.Domain.Entities;

namespace InvMIS.Application.Interfaces
{
    public interface IStockService
    {
        IEnumerable<Stock> GetAll();
        Stock? GetById(int id);
        void Add(Stock stock);
        void Update(Stock stock);
        void Delete(int id);
    }
}
