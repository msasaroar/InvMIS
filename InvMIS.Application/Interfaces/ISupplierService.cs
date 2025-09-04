using InvMIS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvMIS.Application.Interfaces
{
    public interface ISupplierService
    {
        Task<IEnumerable<Supplier>> GetAll();
        Task<Supplier?> GetById(int id);
        Task Add(Supplier supplier);
        Task Update(Supplier supplier);
        Task Delete(int id);
    }
}
