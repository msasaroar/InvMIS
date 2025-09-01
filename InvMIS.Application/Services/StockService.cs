using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;

namespace InvMIS.Application.Services
{
    public class StockService : IStockService
    {
        private readonly Repository<Stock> _repo;

        public StockService(Repository<Stock> repo) => _repo = repo;

        public void Add(Stock stock) => _repo.Add(stock);
        public void Delete(int id) => _repo.Delete(id);
        public IEnumerable<Stock> GetAll() => _repo.GetAll();
        public Stock? GetById(int id) => _repo.GetById(id);
        public void Update(Stock stock) => _repo.Update(stock);
    }
}
