using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;

namespace InvMIS.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _repo;

        public CategoryService(IRepository<Category> repo)
        {
            _repo = repo;
        }

        // Async versions of repository methods
        public async Task AddAsync(Category category)
        {
            await _repo.AddAsync(category);
        }

        public async Task DeleteAsync(int id)
        {
            await _repo.DeleteAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<Category?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task UpdateAsync(Category category)
        {
            await _repo.UpdateAsync(category);
        }
    }
}
