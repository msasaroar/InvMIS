/*
using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;

namespace InvMIS.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly Repository<Category> _repo;

        public CategoryService(Repository<Category> repo)
        {
            _repo = repo;
        }

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
using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;

namespace InvMIS.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly Repository<Category> _repo;

        public CategoryService(Repository<Category> repo) => _repo = repo;

        public void Add(Category category) => _repo.Add(category);
        public void Delete(int id) => _repo.Delete(id);
        public IEnumerable<Category> GetAll() => _repo.GetAll();
        public Category? GetById(int id) => _repo.GetById(id);
        public void Update(Category category) => _repo.Update(category);
    }
}
