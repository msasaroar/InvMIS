using InvMIS.Application.Interfaces;
using InvMIS.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InvMIS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]   // JWT required
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null) return NotFound();
            return Ok(product);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]  // Only Admin can create
        public IActionResult Create(Product product)
        {
            _productService.AddProduct(product);
            return Ok(product);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Admin")]  // Only Admin can update
        public IActionResult Update(int id, Product product)
        {
            if (id != product.Id) return BadRequest();
            _productService.UpdateProduct(product);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]  // Only Admin can delete
        public IActionResult Delete(int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}
