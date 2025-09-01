/*
using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InvMIS.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly Repository<Product> _productRepository;

        public ProductService(Repository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            // Simple Validation Example
            if (string.IsNullOrWhiteSpace(product.Name))
                throw new System.Exception("Product Name is required.");

            await _productRepository.AddAsync(product);
            return product;
        }

        public async Task<Product> UpdateProductAsync(Product product)
        {
            if (product.Id <= 0)
                throw new System.Exception("Invalid Product Id.");

            await _productRepository.UpdateAsync(product);
            return product;
        }

        public async Task<bool> DeleteProductAsync(int id)
        {
            await _productRepository.DeleteAsync(id);
            return true;
        }
    }
}
*/

using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using InvMIS.Infrastructure.Data;
using InvMIS.Infrastructure.Repositories;

namespace InvMIS.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly Repository<Product> _repo;

        public ProductService(Repository<Product> repo) => _repo = repo;

        public void AddProduct(Product product) => _repo.Add(product);
        public void DeleteProduct(int id) => _repo.Delete(id);
        public IEnumerable<Product> GetAllProducts() => _repo.GetAll();
        public Product? GetProductById(int id) => _repo.GetById(id);
        public void UpdateProduct(Product product) => _repo.Update(product);
    }
}

