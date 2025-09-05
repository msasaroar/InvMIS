using InvMIS.Domain.Entities;
using Microsoft.AspNetCore.Identity;
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

                var now = DateTime.UtcNow;
                var adminUser = new User
                {
                    Username = "admin",
                    Role = "Admin",
                    Password = "Admin123",
                    CreatedAt = now,
                    UpdatedAt = now
                };

                // var hasher = new PasswordHasher<User>();
                // var hashPassword = hasher.HashPassword(adminUser, "Admin@123");
                // adminUser.Password = hashPassword;

                context.Users.Add(adminUser);
                await context.SaveChangesAsync();
            }
        }
    }
}
