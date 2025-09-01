/*
using InvMIS.Domain.Entities;

namespace InvMIS.Application.Interfaces
{
    public interface IUserService
    {
        Task<User> RegisterAsync(string username, string password, string role = "User");
        Task<User?> LoginAsync(string username, string password);
    }
}
*/

using InvMIS.Domain.Entities;

namespace InvMIS.Application.Interfaces
{
    public interface IUserService
    {
        User? Authenticate(string username, string password);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
