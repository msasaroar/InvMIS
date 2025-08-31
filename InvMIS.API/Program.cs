
/*
namespace InvMIS.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
*/

using InvMIS.Application.Interfaces;
using InvMIS.Application.Services;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

// PostgreSQL connection string
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<InvMISDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddScoped<Repository<Product>>();      // Generic Repository
builder.Services.AddScoped<IProductService, ProductService>(); // Product Service


builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();
app.Run();

==========================================Next Task(#04):

