﻿namespace InvMIS.Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string Role { get; set; } = "User"; // Default role

        // Optional fields
        public string? FullName { get; set; }
        public string? Email { get; set; }
    }
}

