using InvMIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvMIS.Infrastructure.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAdminAsync(InvMISDbContext context)
        {
            if (!await context.Users.AnyAsync(u => u.Role == "Admin"))
            {
                context.Users.Add(new User
                {
                    Username = "admin",
                    PasswordHash = Convert.ToBase64String(
                        System.Security.Cryptography.SHA256.HashData(System.Text.Encoding.UTF8.GetBytes("Admin@123"))
                    ),
                    Role = "Admin"
                });

                await context.SaveChangesAsync();
            }
        }
    }
}
