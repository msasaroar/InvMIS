using InvMIS.Domain.Entities;

public interface IProductService
{
    Task AddAsync(Product product);
    Task DeleteAsync(int id);
    Task<IEnumerable<Product>> GetAllAsync();
    Task<Product?> GetByIdAsync(int id);
    Task UpdateAsync(Product product);
}
