/*
using InvMIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvMIS.Infrastructure.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAdminAsync(InvMISDbContext context)
        {
            // Ensure database is created
            await context.Database.EnsureCreatedAsync();

            // Check if default admin exists (by Username)
            if (!await context.Users.AnyAsync(u => u.Username == "admin"))
            {
                var passwordHash = Convert.ToBase64String(
                    System.Security.Cryptography.SHA256.HashData(
                        System.Text.Encoding.UTF8.GetBytes("Admin@123")
                    )
                );

                var now = DateTime.UtcNow;

                var adminUser = new User
                {
                    Username = "admin",
                    PasswordHash = passwordHash,
                    Role = "Admin",
                    CreatedAt = now,
                    UpdatedAt = now
                };

                context.Users.Add(adminUser);
                await context.SaveChangesAsync();
            }
        }
    }
}
*/

using InvMIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InvMIS.Infrastructure.Data
{
    public static class DbSeeder
    {
        public static async Task SeedAdminAsync(InvMISDbContext context)
        {
            // Ensure database is created
            await context.Database.EnsureCreatedAsync();

            // Check if default admin exists (by Username)
            if (!await context.Users.AnyAsync(u => u.Username == "admin"))
            {
                var passwordHash = Convert.ToBase64String(
                    System.Security.Cryptography.SHA256.HashData(
                        System.Text.Encoding.UTF8.GetBytes("Admin@123")
                    )
                );

                var now = DateTime.UtcNow;

                var adminUser = new User
                {
                    Username = "admin",
                    PasswordHash = passwordHash,   // এখন entity এর সাথে match করবে
                    Role = "Admin",
                    CreatedAt = now,
                    UpdatedAt = now
                };

                context.Users.Add(adminUser);
                await context.SaveChangesAsync();
            }
        }
    }
}
