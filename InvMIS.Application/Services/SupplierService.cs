using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;

namespace InvMIS.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly Repository<Supplier> _repo;

        public SupplierService(Repository<Supplier> repo) => _repo = repo;

        public void Add(Supplier supplier) => _repo.Add(supplier);
        public void Delete(int id) => _repo.Delete(id);
        public IEnumerable<Supplier> GetAll() => _repo.GetAll();
        public Supplier? GetById(int id) => _repo.GetById(id);
        public void Update(Supplier supplier) => _repo.Update(supplier);
    }
}
