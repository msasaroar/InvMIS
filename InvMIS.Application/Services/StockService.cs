using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvMIS.Application.Services
{
    public class StockService : IStockService
    {
        private readonly IRepository<Stock> _repo;

        public StockService(IRepository<Stock> repo)
        {
            _repo = repo;
        }

        public Task AddAsync(Stock stock) => _repo.AddAsync(stock);

        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);

        public Task<IEnumerable<Stock>> GetAllAsync() => _repo.GetAllAsync();

        public Task<Stock?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public Task UpdateAsync(Stock stock) => _repo.UpdateAsync(stock);
    }
}
