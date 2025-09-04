using InvMIS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvMIS.Application.Interfaces
{
    public interface IStockService
    {
        Task AddAsync(Stock stock);
        Task UpdateAsync(Stock stock);
        Task DeleteAsync(int id);
        Task<Stock?> GetByIdAsync(int id);
        Task<IEnumerable<Stock>> GetAllAsync();
    }
}
