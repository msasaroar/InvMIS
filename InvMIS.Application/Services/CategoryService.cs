/*
using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;

using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;


namespace InvMIS.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly Repository<Category> _repo;   //ERROR - CS0246

        public CategoryService(Repository<Category> repo) => _repo = repo;  //ERROR - CS0246

        public void Add(Category category) => _repo.Add(category);
        public void Delete(int id) => _repo.Delete(id);
        public IEnumerable<Category> GetAll() => _repo.GetAll();
        public Category? GetById(int id) => _repo.GetById(id);
        public void Update(Category category) => _repo.Update(category);
    }
}
*/

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
