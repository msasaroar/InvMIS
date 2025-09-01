/*
using InvMIS.Domain.Entities;

namespace InvMIS.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category? GetById(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}
*/

using InvMIS.Domain.Entities;

namespace InvMIS.Application.Interfaces
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetAll();
        Category? GetById(int id);
        void Add(Category category);
        void Update(Category category);
        void Delete(int id);
    }
}
