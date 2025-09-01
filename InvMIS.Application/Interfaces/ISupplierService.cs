using InvMIS.Domain.Entities;

namespace InvMIS.Application.Interfaces
{
    public interface ISupplierService
    {
        IEnumerable<Supplier> GetAll();
        Supplier? GetById(int id);
        void Add(Supplier supplier);
        void Update(Supplier supplier);
        void Delete(int id);
    }
}
