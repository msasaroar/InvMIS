/*
using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace InvMIS.Application.Services
{
    public class UserService : IUserService
    {
        private readonly InvMISDbContext _context;

        public UserService(InvMISDbContext context)
        {
            _context = context;
        }

        // Register new user
        public async Task<User> RegisterAsync(string username, string password, string role = "User")
        {
            if (await _context.Users.AnyAsync(u => u.Username == username))
                throw new Exception("Username already exists.");

            var user = new User
            {
                Username = username,
                PasswordHash = HashPassword(password),
                Role = role
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return user;
        }

        // Login user
        public async Task<User?> LoginAsync(string username, string password)
        {
            var passwordHash = HashPassword(password);
            return await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.PasswordHash == passwordHash);
        }

        // Simple SHA256 hash
        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
    }
}
*/

using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;
using System.Security.Cryptography;
using System.Text;

namespace InvMIS.Application.Services
{
    public class UserService : IUserService
    {
        private readonly Repository<User> _repo;

        public UserService(Repository<User> repo) => _repo = repo;

        public User? Authenticate(string username, string password)
        {
            var passwordHash = Convert.ToBase64String(SHA256.HashData(Encoding.UTF8.GetBytes(password)));
            return _repo.GetAll().FirstOrDefault(u => u.Username == username && u.PasswordHash == passwordHash);
        }

        public void AddUser(User user) => _repo.Add(user);
        public void DeleteUser(int id) => _repo.Delete(id);
        public IEnumerable<User> GetAllUsers() => _repo.GetAll();
        public void UpdateUser(User user) => _repo.Update(user);
    }
}
