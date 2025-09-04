using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvMIS.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly IRepository<Supplier> _repo;

        public SupplierService(IRepository<Supplier> repo)
        {
            _repo = repo;
        }

        public async Task Add(Supplier supplier)
        {
            await _repo.AddAsync(supplier);
        }

        public async Task Delete(int id)
        {
            await _repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Supplier>> GetAll()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Supplier?> GetById(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task Update(Supplier supplier)
        {
            await _repo.UpdateAsync(supplier);
        }
    }
}
