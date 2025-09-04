using InvMIS.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvMIS.Application.Interfaces
{
    public interface IUserService
    {
        Task<User?> AuthenticateAsync(string username, string password);
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task AddUserAsync(User user);      // ✅ match with implementation
        Task UpdateUserAsync(User user);   // ✅ match with implementation
        Task DeleteUserAsync(int id);
    }
}
